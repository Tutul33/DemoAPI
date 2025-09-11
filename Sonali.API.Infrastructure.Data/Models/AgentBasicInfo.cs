using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentBasicInfo
{
    public int AgentId { get; set; }

    public string? AgentName { get; set; }

    public string? AgentFatherName { get; set; }

    public string? AgentMotherName { get; set; }

    public string? AgentSpouseName { get; set; }

    public string? Gender { get; set; }

    public DateOnly? Dob { get; set; }

    public string? Email { get; set; }

    public string? PresentAddress { get; set; }

    public string? PermanentAddress { get; set; }

    public string? Nationality { get; set; }

    public string? BloodGroup { get; set; }

    public string? CountryCode { get; set; }

    public string? Mobile { get; set; }

    public string? NidpassNo { get; set; }

    public string? EduQualification { get; set; }

    public string? EduUploadFileName { get; set; }

    public string? Tinno { get; set; }

    public string? BankName { get; set; }

    public string? BankBranch { get; set; }

    public string? BankAcno { get; set; }

    public string? CurOccupation { get; set; }

    public string? MaritalStatus { get; set; }

    public string? OrgProvideName { get; set; }

    public string? OrgProvideAddress { get; set; }

    public string? OrgProvideDesignation { get; set; }

    public string? OrgProvideRelation { get; set; }

    public string? NomineeName { get; set; }

    public string? NomineeAge { get; set; }

    public string? NomineeRelation { get; set; }

    public string? NomineeAddress { get; set; }

    public string? GuardianName { get; set; }

    public string? GuardianAge { get; set; }

    public string? GuardianRelation { get; set; }

    public string? GuardianAddress { get; set; }

    public string? Ref1Name { get; set; }

    public string? Ref1Occcupation { get; set; }

    public string? Ref1Address { get; set; }

    public string? Ref1MobileNo { get; set; }

    public string? Ref2Name { get; set; }

    public string? Ref2Occcupation { get; set; }

    public string? Ref2Address { get; set; }

    public string? Ref2MobileNo { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? NidFileName { get; set; }

    public string? AcademicFileName { get; set; }

    public int? ImgStatus { get; set; }

    public int? NidStatus { get; set; }

    public int? AcaStatus { get; set; }

    public int? LicenseFeeStatus { get; set; }

    public string? BankDocFileName { get; set; }

    public DateOnly? BankAcChangeRequestDate { get; set; }

    public DateOnly? BankAcUpdateDate { get; set; }

    public string? Comments { get; set; }

    public string? RoutingNumber { get; set; }

    public byte[]? NidpassNoEncrypted { get; set; }

    public virtual AgentJobDetail? AgentJobDetail { get; set; }

    public virtual ICollection<PolicyProvisionalReceipt> PolicyProvisionalReceipts { get; set; } = new List<PolicyProvisionalReceipt>();
}
