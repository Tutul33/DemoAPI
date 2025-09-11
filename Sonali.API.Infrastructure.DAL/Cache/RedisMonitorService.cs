using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Infrastructure.DAL.Cache
{
    public class RedisMonitorService : BackgroundService
    {
        private readonly ILogger<RedisMonitorService> _logger;
        private readonly IConnectionMultiplexer _redis;

        public RedisMonitorService(
            ILogger<RedisMonitorService> logger,
            IConnectionMultiplexer redis)
        {
            _logger = logger;
            _redis = redis;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("RedisMonitorService started.");

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    var db = _redis.GetDatabase();
                    var pong = await db.PingAsync();
                    if (!RedisInfo.IsRedisAlive)
                    {
                        _logger.LogInformation($"[Redis] Back online! Ping: {pong.TotalMilliseconds} ms");
                    }
                    RedisInfo.IsRedisAlive = true;
                }
                catch
                {
                    if (RedisInfo.IsRedisAlive)
                    {
                        _logger.LogWarning("[Redis] Redis is down!");
                    }
                    RedisInfo.IsRedisAlive = false;
                }

                await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);
            }

            _logger.LogInformation("RedisMonitorService stopped.");
        }
    }
}
