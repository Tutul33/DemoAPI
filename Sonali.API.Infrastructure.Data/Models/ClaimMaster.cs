using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ClaimMaster
{
    public int ClaimId { get; set; }

    public string? ClaimType { get; set; }

    public string? ClaimIdNoChar { get; set; }

    public int? PolicyNo { get; set; }

    public string? PolicyHolderName { get; set; }

    public DateOnly? DeathDate { get; set; }

    public string? CauseOfDeath { get; set; }

    public string? MobileNo { get; set; }

    public string? DeathPlace { get; set; }

    public string? DeathCertificatebyDoctor { get; set; }

    public string? DeathCertByDocId { get; set; }

    public string? LocalGovtAuthorityCert { get; set; }

    public string? LocalGovtId { get; set; }

    public string? CemeteryCertificate { get; set; }

    public string? CemeteryId { get; set; }

    public string? ForeignClearanceCert { get; set; }

    public string? Fcid { get; set; }

    public string? HospitalOrDocName { get; set; }

    public string? HospitalOrDoctorAddress { get; set; }

    public string? DeathComments { get; set; }

    public string? BranchId { get; set; }

    public string? BranchName { get; set; }

    public int? AgentId { get; set; }

    public string? AgentName { get; set; }

    public string? NomineeDoc { get; set; }

    public string? NomineeDocId { get; set; }

    public string? FirDoc { get; set; }

    public string? FirDocId { get; set; }

    public string? PostMortemDoc { get; set; }

    public string? PostMortemDocId { get; set; }

    public string? SpecificReasonofDeath { get; set; }

    public double? CalcSumAssuredAmount { get; set; }

    public double? SuppPolClaimAmount { get; set; }

    public double? BonusAmount { get; set; }

    public double? LienAmountDeduct { get; set; }

    public double? PaidUpValue { get; set; }

    public double? TotalClaimAmount { get; set; }

    public double? ClaimBasicAmountSonali { get; set; }

    public double? ClaimBasicAmountReins { get; set; }

    public double? ClaimSuppAmountSonali { get; set; }

    public double? ClaimSuppAmountReins { get; set; }

    public double? ReinsPayAmt { get; set; }

    public string? ReinsPayDate { get; set; }

    public string? SuppTypesOfClaim { get; set; }

    public string? Photograph { get; set; }

    public string? AllDiagnosticsPaper { get; set; }

    public string? StateofAffair { get; set; }

    public string? CoversUp { get; set; }

    public string? EpacicxrayReport { get; set; }

    public string? EpacicbillForHospital { get; set; }

    public int? Flag { get; set; }

    public int? Smsflag { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateOnly? ApprovalDate { get; set; }

    public string? SupPlaceOfIncident { get; set; }

    public string? SupDateOfIncident { get; set; }

    public string? SupHour { get; set; }

    public string? SupMinute { get; set; }

    public string? Ampm { get; set; }

    public string? SupDateOfNotificationToOrganization { get; set; }

    public string? SupCauseOfDeathAccident { get; set; }

    public double? UnpaidLoanAmt { get; set; }

    public int? LoanId { get; set; }

    public int? Samdid { get; set; }

    public int? ProductId { get; set; }

    public DateOnly? ClaimNotificationDate { get; set; }

    public DateOnly? OriginalClaimFormRecDate { get; set; }

    public DateOnly? PaidDate { get; set; }

    public DateOnly? DeathCertificateReceivingDate { get; set; }

    public DateOnly? LocalGovtAuthorityReceivingDate { get; set; }

    public DateOnly? CemeteryCertificateReceivingDate { get; set; }

    public DateOnly? ForeignClearanceReceivingDate { get; set; }

    public DateOnly? FirdocumentDate { get; set; }

    public DateOnly? PostMortemDate { get; set; }

    public DateOnly? WaiverCertificateDate { get; set; }

    public string? WaiverCertificate { get; set; }

    public string? UnsettledComments { get; set; }

    public int? DocStatus { get; set; }

    public string? ReinsStatus { get; set; }

    public string? ReinsComment { get; set; }

    public string? StatusOnClaimDate { get; set; }

    public double? Tax { get; set; }

    public int? AwaitingDeptId { get; set; }

    public string? Comment { get; set; }

    public bool? IsPreAuditDone { get; set; }

    public bool? IsPostAuditDone { get; set; }

    public bool? IsSentToPreAudit { get; set; }

    public bool? IsNeedToAlter { get; set; }

    public string? NeedToAlterProposedBy { get; set; }

    public DateTime? NeedToAlterProposedDate { get; set; }

    public bool? IsAlterationDone { get; set; }
}
