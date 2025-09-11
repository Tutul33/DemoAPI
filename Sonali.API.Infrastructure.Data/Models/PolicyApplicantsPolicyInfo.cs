using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PolicyApplicantsPolicyInfo
{
    public int ApplicantPolicyId { get; set; }

    public int? ApplicantId { get; set; }

    public int? PolicyId { get; set; }

    public int? SupplimentryPolicyId { get; set; }

    public int? SupplimentryId { get; set; }

    public int? InstallmentTypeId { get; set; }

    public int? SurrenderId { get; set; }

    public int? TermOfYear { get; set; }

    public string? PolicyReason { get; set; }

    public string? YearlyIncome { get; set; }

    public string? SourceOfIncome { get; set; }

    public string? PolicyPayee { get; set; }

    public int? Age { get; set; }

    public double? TotalPolicyAmount { get; set; }

    public double? SupplementryAmount { get; set; }

    public double? BasicAmount { get; set; }

    public double? ExtraPremium { get; set; }

    public double? OthersPremium { get; set; }

    public double? PremiumAmount { get; set; }

    public double? TotalDeposit { get; set; }

    public string? PrBmNo { get; set; }

    public string? OtherPolicyNo { get; set; }

    public string? OtherPolicyCompany { get; set; }

    public double? OtherPolicyAmount { get; set; }

    public string? OtherPolicyName { get; set; }

    public string? OtherPolicyDuration { get; set; }

    public string? OtherPolicyCondition { get; set; }

    public DateTime? OtherPolicyAccpDate { get; set; }

    public string? OtherDuePolicySli { get; set; }

    public string? OtherPolicyRejectInfo { get; set; }

    public string? PolicyRiskAdditonalFactor { get; set; }

    public string? PolicyRiskCategory { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public double Ysapa { get; set; }

    public int PensionAge { get; set; }

    public virtual PolicyApplicantsPersonalInfo? Applicant { get; set; }

    public virtual PolicyInstallmentType? InstallmentType { get; set; }

    public virtual PolicyInfo? Policy { get; set; }

    public virtual ICollection<PolicyFpr> PolicyFprs { get; set; } = new List<PolicyFpr>();
}
