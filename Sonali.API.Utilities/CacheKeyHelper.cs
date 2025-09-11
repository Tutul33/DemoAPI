using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Utilities
{
    public static class CacheKeyHelper
    {
        public static string GenerateCacheKey<T>(string prefix, T obj)
        {
            if (obj == null)
                return prefix;

            var properties = typeof(T).GetProperties()
                                      .OrderBy(p => p.Name); // consistent order
            var keyParts = new List<string> { prefix };

            foreach (var prop in properties)
            {
                var value = prop.GetValue(obj);

                if (value is IEnumerable<string> strEnumerable)
                {
                    keyParts.Add(string.Join(",", strEnumerable));
                }
                else if (value is IEnumerable<int> intEnumerable)
                {
                    keyParts.Add(string.Join(",", intEnumerable));
                }
                else if (value is DateTime dt)
                {
                    keyParts.Add(dt.ToString("yyyyMMddHHmmss"));
                }
                else
                {
                    keyParts.Add(value?.ToString() ?? "null");
                }
            }

            return string.Join(":", keyParts);
        }
    }

}
