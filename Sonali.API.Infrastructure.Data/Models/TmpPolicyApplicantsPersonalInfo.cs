using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TmpPolicyApplicantsPersonalInfo
{
    public int ApplicantId { get; set; }

    public int? AgentId { get; set; }

    public string? ApplicantIdno { get; set; }

    public string? ApplicantNameEng { get; set; }

    public string? ApplicantNameBang { get; set; }

    public string? ApplicantPhotoName { get; set; }

    public string? ApplicantFatherName { get; set; }

    public string? ApplicantMotherName { get; set; }

    public string? ApplicantSpouseName { get; set; }

    public string? Profession { get; set; }

    public string? MobileNo { get; set; }

    public string? Email { get; set; }

    public string? PermanentAddress { get; set; }

    public string? PresentAddress { get; set; }

    public DateOnly? Dob { get; set; }

    public DateOnly? ApplicationDate { get; set; }

    public string? Gender { get; set; }

    public string? BankName { get; set; }

    public string? BankBranch { get; set; }

    public string? BankAccount { get; set; }

    public string? ApplicantPpname { get; set; }

    public string? ApplicantDocumentType { get; set; }

    public string? UploadDocumentId { get; set; }

    public string? ApplicantDocumentName { get; set; }

    public string? BirthPlace { get; set; }

    public string? Nationality { get; set; }

    public string? EduQualification { get; set; }

    public string? CurrentlyWell { get; set; }

    public string? WeightLossOrGain { get; set; }

    public string? LongHolidayForIllness { get; set; }

    public string? PhysicalDisability { get; set; }

    public string? ChikenPox { get; set; }

    public string? ChikenPoxVaccin { get; set; }

    public string? InfectiousDisease { get; set; }

    public string? AncestralDisease { get; set; }

    public string? EpilepticProblem { get; set; }

    public string? FrequentCough { get; set; }

    public string? StomachInfection { get; set; }

    public string? MiltDisease { get; set; }

    public string? UrineStone { get; set; }

    public string? EyeDisease { get; set; }

    public string? GoitrousDisease { get; set; }

    public string? OtherDisease { get; set; }

    public string? TypesOfOperation { get; set; }

    public string? CurrentWeight { get; set; }

    public string? CurrentHeight { get; set; }

    public string? ChestSize { get; set; }

    public string? WaistSize { get; set; }

    public string? IdentificationMark { get; set; }

    public string? WomenEduQualification { get; set; }

    public string? WomenMonthlyIncome { get; set; }

    public string? WomenSourceOfIncome { get; set; }

    public string? WomenEarnAbility { get; set; }

    public string? WomenPayTax { get; set; }

    public string? WomenMaritalStatus { get; set; }

    public string? WomenKids { get; set; }

    public string? WomenKidsExpectation { get; set; }

    public string? WomenLastPeriod { get; set; }

    public string? WomenBaby { get; set; }

    public string? WomenHusbandName { get; set; }

    public string? WomenHusbandOccupation { get; set; }

    public string? WomenHusbandMonthlyIncome { get; set; }

    public string? WomenHusbandPolicyCompanyName { get; set; }

    public string? WomenHusbandPolicyNo { get; set; }

    public double? WomenHusbandPolicyAmount { get; set; }

    public int NotificationStatusFlag { get; set; }

    public string? UnderWrittingComments { get; set; }

    public string? SmsFormate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? Acc { get; set; }

    public string? UniqueKey { get; set; }

    public virtual AgentJobDetail? Agent { get; set; }
}
