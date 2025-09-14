using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class VoucherHeader
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

    public virtual Branch? Branch { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual FinancialYear FinancialYear { get; set; } = null!;

    public virtual ICollection<VoucherEntry> VoucherEntries { get; set; } = new List<VoucherEntry>();
}
