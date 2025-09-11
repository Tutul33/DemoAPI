using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Domain.Entities
{
    public class VoucherDtl
    {
        
        public decimal Id { get; set; }

        public string? VoucherNo { get; set; }
        public string? CodeAndName { get; set; }

        public string ActCode { get; set; } = null!;

        public string? ActName { get; set; }

        public string FromActCode { get; set; } = null!;

        public string ToActCode { get; set; } = null!;

        public decimal DAmount { get; set; }

        public decimal CAmount { get; set; }

        public decimal Amt { get; set; }

        public string? AccStatement { get; set; }

        public string? Descrp { get; set; }

        public string? ModOfPay { get; set; }

        public string? ChkNo { get; set; }

        public DateTime? ChkDt { get; set; }

        public string? OpeningBalance { get; set; }

        public string? ShopId { get; set; }

        public string? UserId { get; set; }

        public DateTime? EntryDate { get; set; }

        public DateTime? DelDate { get; set; }

        public string? DelUser { get; set; }

        public string? MainCode { get; set; }

        public int? SubGroupCat { get; set; }

        public int Transfered { get; set; }

        public DateTime? CreateDate { get; set; }

        public string? CheckedBy { get; set; }

        public string? ApprovedBy { get; set; }

        public string? AuthStatus { get; set; }

        public DateTime? CheckedDate { get; set; }

        public DateTime? ApprovedDate { get; set; }

        //Referral
        public int? ReferralId { get; set; } = 0;

        public string? RefBy { get; set; } = "";

        public string? RefTo { get; set; } = "";

        public string? RefType { get; set; } = "";

        public string? Comments { get; set; } = "";

        public DateTime? ReferDate { get; set; }

        public bool? IsActive { get; set; }
    }
}
