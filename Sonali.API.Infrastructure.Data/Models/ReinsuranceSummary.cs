using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ReinsuranceSummary
{
    public int SummaryId { get; set; }

    public int? ReinsuranceSelection { get; set; }

    public DateOnly? DateFrom { get; set; }

    public DateOnly? DateTo { get; set; }

    public int? TotalNumberOfPolicies { get; set; }

    public double? TotalActualSumAssured { get; set; }

    public double? TotalActualSupplementaryAssured { get; set; }

    public double? TotalSumBasicReinsured { get; set; }

    public double? TotalSumSupplementaryAmount { get; set; }

    public double? ReinsuredBasicPremium { get; set; }

    public double? ReinsuredSupplementaryPremium { get; set; }

    public double? TotalReinsuredPremiumAmount { get; set; }

    public double? NetPayable { get; set; }

    public int? PayStatus { get; set; }

    public string? PaymentType { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? Company { get; set; }
}
