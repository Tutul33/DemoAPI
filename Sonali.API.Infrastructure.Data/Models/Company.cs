using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Company
{
    public int CompanyId { get; set; }

    public string Name { get; set; } = null!;

    public string? Address { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<AccountGroup> AccountGroups { get; set; } = new List<AccountGroup>();

    public virtual ICollection<AccountHead> AccountHeads { get; set; } = new List<AccountHead>();

    public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();

    public virtual ICollection<FinancialYear> FinancialYears { get; set; } = new List<FinancialYear>();

    public virtual ICollection<SubLedger> SubLedgers { get; set; } = new List<SubLedger>();

    public virtual ICollection<VoucherHeader> VoucherHeaders { get; set; } = new List<VoucherHeader>();
}
