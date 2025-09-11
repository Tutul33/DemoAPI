using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class MaturityClaimTemp
{
    public int MaturityClaimId { get; set; }

    public int? ProductId { get; set; }

    public int? InsNo { get; set; }

    public int? FprNo { get; set; }

    public decimal? MaturityAmount { get; set; }

    public decimal? BonusAmount { get; set; }

    public decimal? TotalMaturityAmount { get; set; }

    public string? CreateBy { get; set; }

    public decimal? PremiumDeposited { get; set; }

    public decimal? Tax { get; set; }

    public decimal? PayableToCus { get; set; }

    public string? MatType { get; set; }

    public decimal? Profit { get; set; }
}
