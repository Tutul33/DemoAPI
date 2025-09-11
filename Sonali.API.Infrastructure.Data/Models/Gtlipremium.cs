using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Gtlipremium
{
    public int GtliPremiumId { get; set; }

    public int? TotalNoOfEmployees { get; set; }

    public double? TotalSumAtRisk { get; set; }

    public double? BasicPremiumAmount { get; set; }

    public double? SupplementaryAmount { get; set; }

    public double? ExtraPremiumAmount { get; set; }

    public double? TotalPremiumAmount { get; set; }

    public string? GtliSupplementaryId { get; set; }

    public int? GtliId { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
