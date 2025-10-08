using Sonali.API.Domain.Interface;
using Sonali.API.DomainService.DataService;
using Sonali.API.DomainService.Interface;
using Sonali.API.DomainService.Repository;
using Sonali.API.Infrastructure.DAL.Cache;
using Sonali.API.Infrastructure.DAL.Repository;
using Sonali.API.Utilities.FileManagement;
using Sonali.API.Utilities.ReportManagement;

namespace Sonali.API.ServicesRegister
{
    public static class ServiceRegister
    {
        public static void Register(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IRedisCacheService, RedisCacheService>();
            builder.Services.AddScoped<IFileManager, FileManager>();
            builder.Services.AddScoped<IRdlcService, RdlcService>();
            builder.Services.AddScoped(typeof(IGenericFactoryMSSQL<>), typeof(GenericFactoryMSSQL<>));
            builder.Services.AddScoped<IJwtTokenService, JwtTokenService>();

            builder.Services.AddSingleton<IAgentService, AgentService>();
            builder.Services.AddSingleton<IMLIntentService, MLIntentService>();
            builder.Services.AddSingleton<IKnowledgeBaseService, KnowledgeBaseService>();
            builder.Services.AddScoped<IAIAssistantService,AIAssistantService>();


            builder.Services.AddScoped<ILoginRepository, LoginRepository>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IUserDomainService, UserDomainService>();
            builder.Services.AddScoped<IAccountingDomainService, AccountingDomainService>();
            builder.Services.AddScoped<IVoucherRepository, VoucherRepository>();
            builder.Services.AddScoped<IDemoRepository, DemoRepository>();
            builder.Services.AddScoped<IDemoDomainService, DemoDomainService>();
            builder.Services.AddScoped<IChatRepository, ChatRepository>();
            builder.Services.AddScoped<IChatDomainService, ChatDomainService>();

        }
    }
}
