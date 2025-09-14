using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Branch
{
    public int BranchId { get; set; }

    public int CompanyId { get; set; }

    public string Name { get; set; } = null!;

    public string? Address { get; set; }

    public virtual ICollection<AccountHead> AccountHeads { get; set; } = new List<AccountHead>();

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<VoucherHeader> VoucherHeaders { get; set; } = new List<VoucherHeader>();
}
