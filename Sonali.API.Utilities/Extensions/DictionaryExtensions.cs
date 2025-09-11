using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Utilities
{
    public static class DictionaryExtensions
    {
        public static Hashtable ToHashtable(this Dictionary<string, object?> dict)
        {
            var ht = new Hashtable();
            foreach (var kv in dict)
            {
                ht[kv.Key] = kv.Value ?? DBNull.Value;
            }
            return ht;
        }
    }
}
