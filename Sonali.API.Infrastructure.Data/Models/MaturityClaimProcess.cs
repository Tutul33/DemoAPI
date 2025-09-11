using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class MaturityClaimProcess
{
    public int ClaimId { get; set; }

    public string? MaturityClaimType { get; set; }

    public int? FprId { get; set; }

    public int? InsNo { get; set; }

    public decimal? Sl { get; set; }

    public DateOnly? ClaimDate { get; set; }

    public decimal? MaturityClaimAmount { get; set; }

    public decimal? BonusAmount { get; set; }

    public decimal? TotalAmount { get; set; }

    public int ChequeStatus { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public decimal? PremiumDeposited { get; set; }

    public decimal? Profit { get; set; }

    public decimal? TaxableGross { get; set; }

    public decimal? Tax { get; set; }

    public DateOnly? ApprovalDate { get; set; }

    public DateOnly? PaidDate { get; set; }

    public DateOnly? PaidDateNew { get; set; }
}
