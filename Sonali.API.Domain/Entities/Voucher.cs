using Sonali.API.Domain.DTOs;
using Sonali.API.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Domain.Entities
{
    public class Voucher
    {
        public string? VoucherNo { get; set; }
        public decimal? Amt { get; set; }
        public DateTime? EntryDate { get; set; }
        public string? UserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? TotalCount { get; set; }

    }
}
