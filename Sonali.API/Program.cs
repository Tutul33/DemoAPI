using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.OpenApi.Models;
using Sonali.API.DomainService.Base;
using Sonali.API.Hubs;
using Sonali.API.Infrastructure.DAL.Base;
using Sonali.API.Infrastructure.DAL.Cache;
using Sonali.API.Infrastructure.Data.Configurations;
using Sonali.API.Infrastructure.Data.Data;
using Sonali.API.Infrastructure.Data.Services;
using Sonali.API.Middlewares;
using Sonali.API.ServicesRegister;
using Sonali.API.Utilities;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

// ----------------------------
// Configuration
// ----------------------------
var configBuilder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true)
    .AddEnvironmentVariables();

IConfiguration _configuration = configBuilder.Build();

StaticInfos.MsSqlConnectionString = _configuration.GetConnectionString("MsSqlConnectionString");
//StaticInfos.MsSqlConnectionString = builder.Configuration.GetConnectionString("MsSqlConnectionString") ?? Environment.GetEnvironmentVariable("ConnectionStrings__MsSqlConnectionString");

ReportFileSettings.BasePath = _configuration.GetValue<string>("ReportFile:BasePath");

builder.Services.Configure<JwtSettings>(_configuration.GetSection("Jwt"));
builder.Services.Configure<FileUploadSettings>(_configuration.GetSection("FileUpload"));
builder.Services.Configure<TempFileCleanupSettings>(_configuration.GetSection("TempFileCleanup"));

// Redis configuration
builder.Services.AddSingleton<IConnectionMultiplexer>(sp =>
{
    var configuration = builder.Configuration.GetValue<string>("Redis:Connection");
    var connection = ConnectionMultiplexer.Connect(configuration);

    // Check if Redis is alive
    try
    {
        var db = connection.GetDatabase();
        var pong = db.Ping(); // sends a ping
        RedisInfo.IsRedisAlive = true;
        Console.WriteLine($"Redis is alive. Ping: {pong.TotalMilliseconds} ms");
    }
    catch
    {
        RedisInfo.IsRedisAlive = false;
        Console.WriteLine("Redis is NOT running!");
    }

    return connection;
});
// ----------------------------
// DbContext
// ----------------------------
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(StaticInfos.MsSqlConnectionString);
});

// ----------------------------
// Dependency Injection
// ----------------------------
ServiceRegister.Register(builder);
ValidatorRegister.Register(builder);
builder.Services.AddScoped<FluentValidationActionFilter>();

// ----------------------------
// Controllers & JSON
// ----------------------------
builder.Services.AddControllers(options =>
{
    options.Filters.Add<FluentValidationActionFilter>();
})
.AddJsonOptions(opts =>
{
    opts.JsonSerializerOptions.Converters.Add(new NullableDecimalConverter());
    opts.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());
});

// ----------------------------
// CORS (Environment-based)
// ----------------------------
var allowedOrigins = _configuration.GetSection("AllowedOrigin").Get<string[]>() ?? Array.Empty<string>();
builder.Services.AddCors(options =>
{
    //if (builder.Environment.IsDevelopment())
    //{
    //    // Development: allow everything, no credentials
    //    options.AddPolicy("AllowAll", policy =>
    //        policy.AllowAnyOrigin()
    //              .AllowAnyHeader()
    //              .AllowAnyMethod());
    //}
    //else
    //{
        // Production: allow only your frontend origin, credentials supported (for SignalR/auth)
        options.AddPolicy("AllowedIP", policy =>
            policy.WithOrigins(allowedOrigins)
                  .AllowAnyHeader()
                  .AllowAnyMethod()
                  .AllowCredentials());
    //}
});

// ----------------------------
// Swagger / OpenAPI
// ----------------------------
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Enter 'Bearer' [space] and then your valid token."
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});

// ----------------------------
// AutoMapper
// ----------------------------
builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<MappingProfile>();
});

// ----------------------------
// Hosted services
// ----------------------------
builder.Services.AddHostedService<TempFileCleanupService>();
builder.Services.AddHostedService<RedisMonitorService>();

// ----------------------------
// SignalR
// ----------------------------
builder.Services.AddSignalR();

// ----------------------------
// Rate Limiting
// ----------------------------
RateLimiting.Register(builder);

// ----------------------------
// Response Compression
// ----------------------------
ResponseCompression.Register(builder);

var app = builder.Build();

// ----------------------------
// Static file paths setup
// ----------------------------
var contentRoot = app.Environment.ContentRootPath;

// Reports base path
var reportsBasePath = Path.IsPathRooted(ReportFileSettings.BasePath)
    ? ReportFileSettings.BasePath
    : Path.Combine(contentRoot, ReportFileSettings.BasePath);

// PDF Reports
var pdfReportsPath = Path.Combine(reportsBasePath, "PDF");
Directory.CreateDirectory(pdfReportsPath);

// RDLC Reports
var rdlcReportsPath = Path.Combine(reportsBasePath, "RDLC");
Directory.CreateDirectory(rdlcReportsPath);

// File uploads
var fileUploadPath = _configuration.GetValue<string>("FileUpload:BasePath");
fileUploadPath = Path.IsPathRooted(fileUploadPath)
    ? fileUploadPath
    : Path.Combine(contentRoot, fileUploadPath);
Directory.CreateDirectory(fileUploadPath);

// ----------------------------
// Middleware pipeline
// ----------------------------
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseDefaultFiles();
    app.UseStaticFiles();
}

// Serve extra static file locations
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(fileUploadPath),
    RequestPath = "/uploads"
});
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(pdfReportsPath),
    RequestPath = "/reports/pdf"
});
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(rdlcReportsPath),
    RequestPath = "/reports/rdlc"
});

app.UseRouting();

// Apply CORS before auth
//if (app.Environment.IsDevelopment())
//{
//    app.UseCors("AllowAll");
//}
//else
//{
    app.UseCors("AllowedIP");
//}

// Rate limiting must go early in pipeline
app.UseRateLimiter();

// Custom middlewares
app.UseMiddleware<ApiResponseMiddleware>();
app.UseMiddleware<JwtMiddleware>();


app.UseAuthorization();
app.UseMiddleware<FileValidationMiddleware>();

// Endpoints
app.MapHub<ChatHub>("/chathub");
app.MapControllers();

// Apply sliding window limiter to LoginController.Login using top-level registration
app.MapControllerRoute(
    name: "loginLimiter",
    pattern: "api/Login/Login")
   .RequireRateLimiting("loginLimiter");

app.Run();

/// <summary>
/// Partial class needed for WebApplicationFactory integration tests
/// </summary>
public partial class Program { }
