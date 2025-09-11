using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ReInsuranceCalculation
{
    public int Id { get; set; }

    public int? Fprid { get; set; }

    public int? ProductId { get; set; }

    public DateOnly? CommencementDate { get; set; }

    public string? Gender { get; set; }

    public string? DocId { get; set; }

    public string? PolicyRiskCategory { get; set; }

    public string? ApplicantNameEng { get; set; }

    public DateOnly? Dob { get; set; }

    public int? Age { get; set; }

    public string? Occupation { get; set; }

    public double? TotalPolicyAmount { get; set; }

    public double? ThisPolicyRiskAmount { get; set; }

    public double? SupplementaryAmount { get; set; }

    public double? ReInsSuppAmount { get; set; }

    public double? ReInsSuppPremium { get; set; }

    public double? OtherPolicyBasicAmount { get; set; }

    public double? ReInsBasicAmount { get; set; }

    public double? ReInsBasicRate { get; set; }

    public double? ReInsBasicPremium { get; set; }

    public double? ReinsuranceTotalPremium { get; set; }

    public double? ReinsuranceActualPay { get; set; }

    public int? ReinsCount { get; set; }

    public int? ApplicantId { get; set; }

    public int? NomineeId { get; set; }
}
