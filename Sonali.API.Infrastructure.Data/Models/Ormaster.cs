using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Ormaster
{
    public int OrmasterId { get; set; }

    public int? Fprid { get; set; }

    public int? ApplicantId { get; set; }

    public string? DocId { get; set; }

    public int? ProductsId { get; set; }

    public DateOnly? Dob { get; set; }

    public int? Age { get; set; }

    public string? Occupation { get; set; }

    public int? SupplimentaryId { get; set; }

    public int? TermOfYear { get; set; }

    public string? PolicyRiskAdditonalFactor { get; set; }

    public int? TotalNumberOfInstallments { get; set; }

    public int? TotalInstallmentsPaid { get; set; }

    public int? DueInstallments { get; set; }

    public int? CurrentTotInstallmentNoDue { get; set; }

    public int? InstallmentTypeId { get; set; }

    public double? TotalPolicyAmount { get; set; }

    public int? PensionAge { get; set; }

    public double? Ysapa { get; set; }

    public double? BasicPremiumAmount { get; set; }

    public double? SupplementaryAmount { get; set; }

    public double? ExtraPremiumAmount { get; set; }

    public double? OthersPremiumAmount { get; set; }

    public double? TotalPremium { get; set; }

    public double? SuspenseAmount { get; set; }

    public double? TotalPremPay { get; set; }

    public double? SoFarPaidAmount { get; set; }

    public double? TotalPremDue { get; set; }

    public double? LateFees { get; set; }

    public double TotalLateFees { get; set; }

    public DateOnly? LateFeesDueDate { get; set; }

    public int? NoOfLateFees { get; set; }

    public int LateFeesFlag { get; set; }

    public int? NthYear { get; set; }

    public DateOnly? CommencementDate { get; set; }

    public DateOnly? LastPremiumDueDate { get; set; }

    public DateOnly? NextPremiumDueDate { get; set; }

    public int? BranchCode { get; set; }

    public int? SmsFlag { get; set; }

    public DateOnly? RowEntryDueDate { get; set; }

    public int? OrentryId { get; set; }

    public int? AgentId { get; set; }

    public string? AgeVarify { get; set; }

    public string? Email { get; set; }

    public string? CountryCode { get; set; }

    public string? MobileNo { get; set; }

    public int AlterationFlagMaster { get; set; }

    public int AlterSaflag { get; set; }

    public int AlterInsFlag { get; set; }

    public int? Lien { get; set; }

    public int? LienTerm { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string RecFlag { get; set; } = null!;

    public int? AgentValid { get; set; }

    public string? EftnStatus { get; set; }

    public string? TransferBy { get; set; }

    public DateTime? TransferDate { get; set; }
}
