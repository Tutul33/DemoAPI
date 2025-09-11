using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PrSummary
{
    public int Sl { get; set; }

    public string? Yr { get; set; }

    public string? Months { get; set; }

    public int? TotalApplicants { get; set; }

    public int? FaId { get; set; }

    public int? SamdId { get; set; }

    public int? BranchId { get; set; }

    public double? TotalPremiumAmount { get; set; }

    public double? TotalNetCommission { get; set; }

    public double? TotalNetRetention { get; set; }
}
