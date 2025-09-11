using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Domain.Entities
{
    public class ChartOfAccounts
    {
        public long Id { get; set; }
        public string Parent { get; set; } = string.Empty;
        public string Key { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public int AccLevel { get; set; } = 0;
    }
}
