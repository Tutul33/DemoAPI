using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class GtlimakeaClaim
{
    public int GtliclaimId { get; set; }

    public int? Gtliid { get; set; }

    public string? CompanyName { get; set; }

    public string? RegistrationNumber { get; set; }

    public string? CompanyAddress { get; set; }

    public string? CertificateIssueNo { get; set; }

    public string? NameofLifeInsured { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public string LastResidenceAddress { get; set; } = null!;

    public string? ListNo { get; set; }

    public DateOnly? ClaimDate { get; set; }

    public int? Slno { get; set; }

    public string? EmpIdJobId { get; set; }

    public DateOnly? JoiningDate { get; set; }

    public DateOnly? DateofLastAttendanceatWork { get; set; }

    public string? NomineeName { get; set; }

    public string? RelationshipWithNominee { get; set; }

    public string? AddressofNominee { get; set; }

    public string? NatureOfClaim { get; set; }

    public string? RecDateofOcf { get; set; }

    public int? ClaimSlnoOftheCompany { get; set; }

    public DateOnly ClaimNotificationDate { get; set; }

    public string? PlaceofIncident { get; set; }

    public DateOnly? DateofIncident { get; set; }

    public string? TimeofIncident { get; set; }

    public string? DeathCertificate { get; set; }

    public string? EmploymentCertificate { get; set; }

    public string? IdcardJobcard { get; set; }

    public string? ServicesBook { get; set; }

    public string? AttendanceSheet { get; set; }

    public string? SalaryStatement { get; set; }

    public string? LeaveApprovalSheet { get; set; }

    public string? Firreport { get; set; }

    public string? PostMortemReport { get; set; }

    public string? NewsPaperReport { get; set; }

    public string? EmployerStatementofInjury { get; set; }

    public string? PhotographofConcerned { get; set; }

    public string? PhysicianCertificate { get; set; }

    public string? PermanentandTotalDisability { get; set; }

    public string? PermanentandPartialDisability { get; set; }

    public string? MajorDiseaseDisability { get; set; }

    public double? ClaimAmount { get; set; }

    public double? CalculatedClaimAmount { get; set; }

    public int? Flag { get; set; }

    public int? Smsflag { get; set; }

    public string? CommentsView { get; set; }

    public double? SumAssured { get; set; }

    public double? SupplementaryAmount { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? Discard { get; set; }

    public DateOnly? ApprovalDate { get; set; }

    public string? NatureOfSubClaim { get; set; }

    public string? HiemploymentCertificate { get; set; }

    public string? Hihospitalizationrecommendation { get; set; }

    public string? Hidischargecertificate { get; set; }

    public string? Hihospitalized { get; set; }

    public string? HibillofConsultants { get; set; }

    public string? HiroomCharges { get; set; }

    public string? Hibillofmedicine { get; set; }

    public string? HisurgicalOperationcharges { get; set; }

    public string? Hiancillarycharges { get; set; }

    public string? Hixray { get; set; }

    public string? Hiultrasonography { get; set; }

    public string? Hicbc { get; set; }

    public DateOnly? PaidDate { get; set; }

    public string? UnsettledComments { get; set; }

    public int? DocStatus { get; set; }

    public int? AwaitingDeptId { get; set; }

    public string? AwaitingComment { get; set; }

    public bool? IsPreAuditDone { get; set; }

    public bool? IsPostAuditDone { get; set; }

    public bool? IsSentToPreAudit { get; set; }
}
