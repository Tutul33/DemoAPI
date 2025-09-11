using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class GtliclaimInvestigation
{
    public int GtliclaimInvestigationId { get; set; }

    public int? Gtliid { get; set; }

    public string? InvOfficerName { get; set; }

    public int? InvOfficerId { get; set; }

    public int? BranchId { get; set; }

    public string? Designation { get; set; }

    public string? DeathCertificate { get; set; }

    public string? EmploymentCertificate { get; set; }

    public string? IdcardJobCard { get; set; }

    public string? ServiceBook { get; set; }

    public string? AttendanceSheet { get; set; }

    public string? SalarySheet { get; set; }

    public string? LeaveApprovalSheet { get; set; }

    public string? Firreport { get; set; }

    public string? PostMortemReport { get; set; }

    public string? NewsPaperReport { get; set; }

    public string? EmpStmtInjury { get; set; }

    public string? ConcernedPhoto { get; set; }

    public string? PhysicianCertificate { get; set; }

    public string? ClaimId { get; set; }

    public string? IntervieweeName { get; set; }

    public string? IntervieweeAddress { get; set; }

    public string? IntervieweeComments { get; set; }

    public string? IntervieweeContact { get; set; }

    public DateTime? IntervieweeDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? HiemploymentCertificate { get; set; }

    public string? Hihospitalizationrecommendation { get; set; }

    public string? Hihospitalized { get; set; }

    public string? Hidischargecertificate { get; set; }

    public string? HibillofConsultants { get; set; }

    public string? HiroomCharges { get; set; }

    public string? Hibillofmedicine { get; set; }

    public string? HisurgicalOperationcharges { get; set; }

    public string? Hiancillarycharges { get; set; }

    public string? Hixray { get; set; }

    public string? Hiultrasonography { get; set; }

    public string? Hicbc { get; set; }
}
