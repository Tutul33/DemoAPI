using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class RequisitionAudit
{
    public int Sl { get; set; }

    public int? BranchId { get; set; }

    public string? BranchName { get; set; }

    public int? MonthNo { get; set; }

    public string? MonthName { get; set; }

    public int? Year { get; set; }
}
