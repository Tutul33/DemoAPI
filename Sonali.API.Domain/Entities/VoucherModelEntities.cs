using Sonali.API.Domain.DTOs;
using Sonali.API.Utilities.EntityExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Domain.Entities
{
    public class VoucherModelEntities:AuditableEntity<int>
    {
        public long VoucherId { get; set; }

        public int CompanyId { get; set; }

        public int? BranchId { get; set; }

        public int FinancialYearId { get; set; }

        public string VoucherType { get; set; } = null!;

        public string VoucherNo { get; set; } = null!;

        public DateOnly Date { get; set; }

        public string? Narration { get; set; }

        public string? Reference { get; set; }

        public bool Posted { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string? ModifiedBy { get; set; }

        public DateTime? ModifiedAt { get; set; }

        public List<VoucherEntryModelEntities> VoucherEntries { get; set; } = new List<VoucherEntryModelEntities>();
    }
    public class VoucherEntryModelEntities:RowEntity<int>
    {
        public long EntryId { get; set; }

        public long VoucherId { get; set; }

        public int AccountHeadId { get; set; }

        public int? SubLedgerId { get; set; }

        public decimal Debit { get; set; }

        public decimal Credit { get; set; }

        public string? Description { get; set; }

        public int LineOrder { get; set; }

        public decimal? SignedAmount { get; set; }
    }
}
