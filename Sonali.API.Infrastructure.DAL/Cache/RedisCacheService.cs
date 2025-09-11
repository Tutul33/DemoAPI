using Newtonsoft.Json;
using StackExchange.Redis;
using System.Text.Json;

namespace Sonali.API.Infrastructure.DAL.Cache
{

    public interface IRedisCacheService
    {
        Task SetAsync<T>(string key, T value, TimeSpan? expiry = null);
        Task<T?> GetAsync<T>(string key);
        Task RemoveAsync(string key);
        Task ClearAllAsync();
        Task<bool> IsRedisAliveAsync();
    }

    public class RedisCacheService : IRedisCacheService
    {
        private readonly IConnectionMultiplexer _redis;

        public RedisCacheService(IConnectionMultiplexer redis)
        {
            _redis = redis;
        }

        public async Task SetAsync<T>(string key, T value, TimeSpan? expiry = null)
        {
            var db = _redis.GetDatabase();
            var json = JsonConvert.SerializeObject(value);
            await db.StringSetAsync(key, json, expiry);
        }

        public async Task<T?> GetAsync<T>(string key)
        {
            var db = _redis.GetDatabase();
            var value = await db.StringGetAsync(key);

            if (value.IsNullOrEmpty)
                return default;

            return JsonConvert.DeserializeObject<T>(value);
        }

        public async Task RemoveAsync(string key)
        {
            var db = _redis.GetDatabase();
            await db.KeyDeleteAsync(key);
        }
        public async Task ClearAllAsync()
        {
            var endpoints = _redis.GetEndPoints();
            foreach (var endpoint in endpoints)
            {
                var server = _redis.GetServer(endpoint);

                // Warning: Keys("*") can be slow for large datasets. Use carefully in production.
                var keys = server.Keys();
                foreach (var key in keys)
                {
                    await _redis.GetDatabase().KeyDeleteAsync(key);
                }
            }
        }
        public async Task<bool> IsRedisAliveAsync()
        {
            try
            {
                var endpoints = _redis.GetEndPoints();
                foreach (var endpoint in endpoints)
                {
                    var server = _redis.GetServer(endpoint);
                    if (!server.IsConnected)
                        return false;
                }
                var db = _redis.GetDatabase();
                var pong = await db.PingAsync();
                return true; // Redis is alive
            }
            catch
            {
                return false; // Redis is not available
            }
        }


    }

}
