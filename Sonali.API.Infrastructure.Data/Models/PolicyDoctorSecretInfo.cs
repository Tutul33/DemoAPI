using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PolicyDoctorSecretInfo
{
    public int DoctorsReportId { get; set; }

    public int? EmpId { get; set; }

    public int? ApplicantId { get; set; }

    public string? DoctRegNo { get; set; }

    public string? RelatedToApplicant { get; set; }

    public string? AppMoreAge { get; set; }

    public string? AppEarlyAge { get; set; }

    public string? AppSeek { get; set; }

    public string? AppVisionProb { get; set; }

    public string? AppSkinDisease { get; set; }

    public string? AppStomachProb { get; set; }

    public string? AppLeverProb { get; set; }

    public string? AppTeethProb { get; set; }

    public string? AppBreath { get; set; }

    public string? AppHeartProb { get; set; }

    public string? AppHeartIssue { get; set; }

    public string? AppPulse { get; set; }

    public string? AppArtery { get; set; }

    public string? AppBloodPres { get; set; }

    public string? AppHeartBeat { get; set; }

    public string? AppSexDisease { get; set; }

    public string? AppAbnormality { get; set; }

    public string? UtGravity { get; set; }

    public string? UtSugar { get; set; }

    public string? UtAlbumen { get; set; }

    public string? UtUrineNorm { get; set; }

    public string? UtExByDoct { get; set; }

    public string? AppHeight { get; set; }

    public string? AppWeight { get; set; }

    public string? AppChestSizeDurBr { get; set; }

    public string? AppChestSizeAfterBr { get; set; }

    public string? AppWaistSize { get; set; }

    public string? AppChanceOfLiving { get; set; }

    public string? AppLifeStatus { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual PolicyApplicantsPersonalInfo? Applicant { get; set; }

    public virtual PayEmployeesBasicInfo? Emp { get; set; }
}
