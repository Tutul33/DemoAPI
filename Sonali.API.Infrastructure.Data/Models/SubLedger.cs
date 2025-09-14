using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class SubLedger
{
    public int SubLedgerId { get; set; }

    public int CompanyId { get; set; }

    public string Type { get; set; } = null!;

    public string? ReferenceId { get; set; }

    public string Name { get; set; } = null!;

    public string? Contact { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<VoucherEntry> VoucherEntries { get; set; } = new List<VoucherEntry>();
}
