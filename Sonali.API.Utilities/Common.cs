using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Utilities
{
    public class CommonModel:Paging
    {
        public int? Id { get; set; }
        public string? Search { get; set; }
        public string? Status { get; set; }
        public int? TotalCount { get; set; }
    }
    public class Paging
    {
        public int? PageNumber { get; set; } = 1;
        public int? PageSize { get; set; } = 10;
        public int? Total { get; set; } = 0;
    }
}
