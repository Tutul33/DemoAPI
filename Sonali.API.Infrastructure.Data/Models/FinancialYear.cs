using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class FinancialYear
{
    public int FinancialYearId { get; set; }

    public int CompanyId { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public bool IsLocked { get; set; }

    public DateOnly? LockStartDate { get; set; }

    public DateOnly? LockEndDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<VoucherHeader> VoucherHeaders { get; set; } = new List<VoucherHeader>();
}
