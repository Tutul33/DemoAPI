using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class KycMaster
{
    public int MasterKycId { get; set; }

    public int? ApplciantId { get; set; }

    public int? Fprid { get; set; }

    public int? ProductId { get; set; }

    public int? ProductCatId { get; set; }

    public string? ApplicantName { get; set; }

    public string? ApplicantFathersName { get; set; }

    public string? ApplicantMothersName { get; set; }

    public string? ApplicantSpouseName { get; set; }

    public DateOnly? Dob { get; set; }

    public string? Nationality { get; set; }

    public string? TelRes { get; set; }

    public string? TelOffice { get; set; }

    public string? CountryCode { get; set; }

    public string? MobileNo { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? PresentAddress { get; set; }

    public string? PermanentAddress { get; set; }

    public string? DocType { get; set; }

    public string? DocId { get; set; }

    public DateOnly? DocExp { get; set; }

    public string? RiskCat { get; set; }

    public string? ETin { get; set; }

    public string? Occupation { get; set; }

    public string? JobTitle { get; set; }

    public string? JobDesc { get; set; }

    public string? OfficeNameAddress { get; set; }

    public string? SourceofIncome { get; set; }

    public string? IncomeSourceVerficationmethod { get; set; }

    public int? InsTypeId { get; set; }

    public double? TotalPremiumAmount { get; set; }

    public string? MediumOfPayment { get; set; }

    public string? BankName { get; set; }

    public string? BankBranch { get; set; }

    public string? BankAccNo { get; set; }

    public string? Comments { get; set; }

    public int? NoOfNominees { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? Updatedate { get; set; }
}
