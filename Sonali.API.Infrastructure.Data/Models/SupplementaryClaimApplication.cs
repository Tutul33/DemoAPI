using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class SupplementaryClaimApplication
{
    public int Id { get; set; }

    public string? PolicyNumber { get; set; }

    public string? TypeOfClaim { get; set; }

    public string? NameOfPolicyHolder { get; set; }

    public string? PresentAddressOfPolicyHolder { get; set; }

    public int? MobileNo1 { get; set; }

    public int? MobileNo2 { get; set; }

    public DateOnly? DateOfAccidentOrSickness { get; set; }

    public string? TimeOfAccident { get; set; }

    public string? PlaceOfAccidentOrSickness { get; set; }

    public string? NatureOfAccidentOrSickness { get; set; }

    public string? TypeOfAccidentOrSickness { get; set; }

    public int? ToptalClaimAmount { get; set; }

    public string? BankName { get; set; }

    public string? AccountName { get; set; }

    public string? BankAcno { get; set; }

    public string? BranchName { get; set; }

    public string? BankRoutineNo { get; set; }

    public string? BlankCheckOrBankStatementFileName { get; set; }

    public string? HospitalDischargeCertificate { get; set; }

    public string? DoctorPrescription { get; set; }

    public string? DiagnosticOrInvestigationOrPathoplogicalReport { get; set; }

    public string? ImagingReports { get; set; }

    public string? HospitalBills { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CrerateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
