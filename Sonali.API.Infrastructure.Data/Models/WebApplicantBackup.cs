using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class WebApplicantBackup
{
    public int Id { get; set; }

    public int? WebApplicantId { get; set; }

    public string? ApplicantNameEng { get; set; }

    public string? ApplicantPhotoName { get; set; }

    public string? ApplicantFatherName { get; set; }

    public string? ApplicantMotherName { get; set; }

    public string? Profession { get; set; }

    public string? CountryCodeName { get; set; }

    public string? CountryCode { get; set; }

    public string? MobileNo { get; set; }

    public string? Email { get; set; }

    public string? PermanentAddress { get; set; }

    public string? PresentAddress { get; set; }

    public DateOnly? Dob { get; set; }

    public DateOnly? ApplicationDate { get; set; }

    public string? Gender { get; set; }

    public string? ApplicantDocumentType { get; set; }

    public string? DocumentId { get; set; }

    public string? ApplicantDocumentName { get; set; }

    public int? CompanyId { get; set; }

    public string? PolicyHolderSignature { get; set; }

    public int? PolicyId { get; set; }

    public int? SupplimentryPolicyId { get; set; }

    public int? SupplimentryId { get; set; }

    public int? InstallmentTypeId { get; set; }

    public int? TermOfYear { get; set; }

    public string? YearlyIncome { get; set; }

    public double? TotalPolicyAmount { get; set; }

    public double? SupplementryAmount { get; set; }

    public double? BasicAmount { get; set; }

    public double? ExtraPremium { get; set; }

    public double? OthersPremium { get; set; }

    public double? PremiumAmount { get; set; }

    public string? PolicyRiskAdditonalFactor { get; set; }

    public double? Ysapa { get; set; }

    public int? PensionAge { get; set; }

    public string? PolicyRiskCategory { get; set; }

    public string? TranId { get; set; }

    public string? ValId { get; set; }

    public double? PaidAmount { get; set; }

    public string? CardType { get; set; }

    public double? StoreAmount { get; set; }

    public string? TranCase { get; set; }

    public string? RelationCode { get; set; }

    public DateTime? PaidDate { get; set; }
}
