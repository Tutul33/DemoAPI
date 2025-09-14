using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class LockEntry
{
    public int LockEntryId { get; set; }

    public DateTime LockStart { get; set; }

    public DateTime LockEnd { get; set; }

    public string Reason { get; set; } = null!;

    public int CompanyId { get; set; }

    public int BranchId { get; set; }
}
