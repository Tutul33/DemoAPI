using Sonali.API.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Domain.DTOs
{
    public class VoucherSearchDTO:CommonModel
    {
        public string UserIds { get; set; } = "";
        public string VoucherNos { get; set; } = "";
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string VoucherType { get; set; } = "";
        public string FinanceBankingUser { get; set; } = "";
    }
}
