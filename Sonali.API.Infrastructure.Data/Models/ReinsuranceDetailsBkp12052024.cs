using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ReinsuranceDetailsBkp12052024
{
    public int SlNo { get; set; }

    public int? SummaryId { get; set; }

    public int? Fprid { get; set; }

    public string? PolicyNumber { get; set; }

    public int? PlanId { get; set; }

    public DateOnly? CommencementDate { get; set; }

    public string? Gender { get; set; }

    public string? ApplicantName { get; set; }

    public int? Age { get; set; }

    public string? Occupation { get; set; }

    public DateOnly? Dob { get; set; }

    public double? TotalPolicyAmount { get; set; }

    public double? SupplementaryAmount { get; set; }

    public double? ReinsuredAmount { get; set; }

    public double? ReInsuredSupplementaryAmount { get; set; }

    public double? ReinsuranceBasicRate { get; set; }

    public double? ReinsuranceSupplementryRate { get; set; }

    public double? ReinsuranceBasicPremium { get; set; }

    public double? ReinsuranceSupplementaryPremium { get; set; }

    public double? ReinsuranceTotalPremium { get; set; }

    public double? ReinsurancePay { get; set; }

    public string? PaymentStatus { get; set; }

    public int? PayCount { get; set; }

    public string? Company { get; set; }

    public double? PrevSumAtRisk { get; set; }
}
