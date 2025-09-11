using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class BonusDetails16
{
    public int Sl { get; set; }

    public int? Fprid { get; set; }

    public double? SumAssured { get; set; }

    public int? Age { get; set; }

    public int? NthYr { get; set; }

    public double? YrlyTotPrem { get; set; }

    public double? YrlyMngmntExpRate { get; set; }

    public double? YrlyMngmntExpAmt { get; set; }

    public double? ReqDeathClaimAmt { get; set; }

    public double? DeathBenRate { get; set; }

    public double? RiskPrem { get; set; }

    public double? LeftAmt { get; set; }

    public double? PrevYrAmt { get; set; }

    public double? InvFundAmt { get; set; }

    public double? InvEarningAmt { get; set; }

    public double? YrEndingMatVal { get; set; }

    public double? YrEndingCumBonusAmt { get; set; }

    public DateOnly? BonusDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
