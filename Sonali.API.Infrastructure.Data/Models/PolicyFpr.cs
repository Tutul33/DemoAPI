using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PolicyFpr
{
    public int PolicyFprid { get; set; }

    public int? PolicyId { get; set; }

    public int? SurrenderId { get; set; }

    public int? SupplimentryId { get; set; }

    public int? ApplicantPolicyId { get; set; }

    public int? InsurncePlanId { get; set; }

    public string? PolicyNo { get; set; }

    public DateTime? PolicyStartDate { get; set; }

    public double? InstallmentValue { get; set; }

    public int? Fprno { get; set; }

    public double? TotalPremium { get; set; }

    public double? DueBalance { get; set; }

    public virtual PolicyApplicantsPolicyInfo? ApplicantPolicy { get; set; }

    public virtual PolicyInsurancePlan? InsurncePlan { get; set; }

    public virtual PolicyInfo? Policy { get; set; }

    public virtual PolicySupplimentryEntry? Supplimentry { get; set; }
}
