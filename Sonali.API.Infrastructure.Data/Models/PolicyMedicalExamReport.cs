using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PolicyMedicalExamReport
{
    public int MedicalRecordId { get; set; }

    public int? ApplicantId { get; set; }

    public string? GenealogicalDisease { get; set; }

    public string? NeuralHeadache { get; set; }

    public string? VomitingDisease { get; set; }

    public string? BowelInfection { get; set; }

    public string? SpinalDisease { get; set; }

    public string? HeartDisease { get; set; }

    public string? SexDisease { get; set; }

    public string? MuscleInjury { get; set; }

    public string? CancerDisease { get; set; }

    public string? OtherDisease { get; set; }

    public string? XrayExam { get; set; }

    public string? ReasonOfExam { get; set; }

    public string? ExamTime { get; set; }

    public string? ExamDoctorsName { get; set; }

    public string? ExamDoctorsAddress { get; set; }

    public string? StayingMedical { get; set; }

    public string? StayingTime { get; set; }

    public string? StayingPlace { get; set; }

    public string? StayingReason { get; set; }

    public string? WomenPregnancyStatus { get; set; }

    public string? WomenNoOfKid { get; set; }

    public string? WomenBirthDifficulties { get; set; }

    public string? WomenBreastProblem { get; set; }

    public string? WomenLastPeriod { get; set; }

    public virtual PolicyApplicantsPersonalInfo? Applicant { get; set; }
}
