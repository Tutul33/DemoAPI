using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AccountHead
{
    public int AccountHeadId { get; set; }

    public int CompanyId { get; set; }

    public int? BranchId { get; set; }

    public int AccountGroupId { get; set; }

    public string? Code { get; set; }

    public string Name { get; set; } = null!;

    public bool IsControlAccount { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual AccountGroup AccountGroup { get; set; } = null!;

    public virtual Branch? Branch { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<VoucherEntry> VoucherEntries { get; set; } = new List<VoucherEntry>();
}
