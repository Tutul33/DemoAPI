using Microsoft.AspNetCore.RateLimiting;
using System.Threading.RateLimiting;

namespace Sonali.API.ServicesRegister
{
    public static class RateLimiting
    {
        public static void Register(WebApplicationBuilder builder)
        {
            builder.Services.AddRateLimiter(options =>
            {
                // Global limiter per client IP
                options.GlobalLimiter = PartitionedRateLimiter.Create<HttpContext, string>(httpContext =>
                {
                    var forwardedFor = httpContext.Request.Headers["X-Forwarded-For"].FirstOrDefault();
                    string clientIp = !string.IsNullOrWhiteSpace(forwardedFor)
                        ? forwardedFor.Split(',')[0].Trim()
                        : httpContext.Connection.RemoteIpAddress?.ToString() ?? "unknown";

                    return RateLimitPartition.GetFixedWindowLimiter(
                        partitionKey: clientIp,
                        factory: _ => new FixedWindowRateLimiterOptions
                        {
                            PermitLimit = 100, // 100 requests
                            Window = TimeSpan.FromMinutes(1), // per 1 minute
                            QueueProcessingOrder = QueueProcessingOrder.OldestFirst,
                            QueueLimit = 0
                        });
                });

                //// Stricter limiter for login endpoint
                //options.AddFixedWindowLimiter("loginLimiter", opt =>
                //{
                //    opt.PermitLimit = 5; // 5 requests
                //    opt.Window = TimeSpan.FromMinutes(1); // per 1 minute
                //    opt.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
                //    opt.QueueLimit = 0;
                //});

                // Sliding window limiter for login
                options.AddSlidingWindowLimiter("loginLimiter", opt =>
                {
                    opt.PermitLimit = 5;
                    opt.Window = TimeSpan.FromMinutes(1);
                    opt.SegmentsPerWindow = 6; // 10-second segments for smooth sliding
                    opt.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
                    opt.QueueLimit = 0;
                });

                // What happens on rejection
                options.OnRejected = async (context, token) =>
                {
                    context.HttpContext.Response.StatusCode = StatusCodes.Status429TooManyRequests;
                    await context.HttpContext.Response.WriteAsync("Too many requests. Please try again later.", token);
                };
            });
        }
    }
}
