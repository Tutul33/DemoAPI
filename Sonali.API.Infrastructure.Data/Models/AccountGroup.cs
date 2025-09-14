using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AccountGroup
{
    public int AccountGroupId { get; set; }

    public int CompanyId { get; set; }

    public string? Code { get; set; }

    public string Name { get; set; } = null!;

    public int? ParentGroupId { get; set; }

    public string? Type { get; set; }

    public virtual ICollection<AccountHead> AccountHeads { get; set; } = new List<AccountHead>();

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<AccountGroup> InverseParentGroup { get; set; } = new List<AccountGroup>();

    public virtual AccountGroup? ParentGroup { get; set; }
}
