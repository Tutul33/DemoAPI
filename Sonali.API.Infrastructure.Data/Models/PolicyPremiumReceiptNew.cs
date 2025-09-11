using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PolicyPremiumReceiptNew
{
    public int Fprid { get; set; }

    public int? FprNumber { get; set; }

    public DateOnly? Fprdate { get; set; }

    public int? ApplicantId { get; set; }

    public DateOnly? ApplicantionDate { get; set; }

    public string? DocId { get; set; }

    public string? UnitOfficeCode { get; set; }

    public string? BranchOfficeCode { get; set; }

    public DateOnly? CommencementDate { get; set; }

    public string? PolicyNumber { get; set; }

    public int? PilicyId { get; set; }

    public int? TermOfYear { get; set; }

    public string? InstallmentTypeName { get; set; }

    public string? SurrOptName { get; set; }

    public string? SubPolicyName { get; set; }

    public double? TotalPolicyAmount { get; set; }

    public string? ApplicantNameEng { get; set; }

    public string? PresentAddress { get; set; }

    public string? Admitted { get; set; }

    public int? Age { get; set; }

    public string? ExtraCondition { get; set; }

    public double? ExtraPremium { get; set; }

    public double? PremiumAmount { get; set; }

    public double? SupplementaryAmount { get; set; }

    public double? Others { get; set; }

    public double? TotalPremium { get; set; }

    public string? PrBmNo { get; set; }

    public DateOnly? DepositDate { get; set; }

    public double? DepositeAmount { get; set; }

    public double? TotalDeposit { get; set; }

    public double? AdjustedPremium { get; set; }

    public double? SuspensePremium { get; set; }

    public int NoPay { get; set; }

    public int NthYear { get; set; }

    public DateOnly? NextPremiumDueDate { get; set; }

    public int AutoSmsFlag { get; set; }

    public string? Faid { get; set; }

    public string? UmId { get; set; }

    public string? Bmid { get; set; }

    public string? Bcid { get; set; }

    public string? Dcid { get; set; }

    public string? Rcid { get; set; }

    public string? Dvcid { get; set; }

    public string? Sgmid { get; set; }

    public string? AmdId { get; set; }

    public string? Samdid { get; set; }

    public string? Acc { get; set; }

    public int PsdeliveryFlag { get; set; }

    public string? PsdeliveredBy { get; set; }

    public DateTime? PsdelDate { get; set; }

    public int? Lien { get; set; }

    public int? LienYear { get; set; }

    public int? Language { get; set; }

    public int? PsdeliveryBranchId { get; set; }

    public int? PsdeliveredToEmpId { get; set; }

    public int? PsdeliveredToAgentId { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public string? Comment { get; set; }

    public int? CommentStatus { get; set; }
}
