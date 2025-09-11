using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Infrastructure.Data.Configurations
{
    public class TempFileCleanupSettings
    {
        public string[] Folders { get; set; } = Array.Empty<string>();
        public int FileAgeMinutes { get; set; } = 5;
        public int ScanIntervalSeconds { get; set; } = 60;
    }

}
