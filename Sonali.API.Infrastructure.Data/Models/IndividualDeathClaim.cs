using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class IndividualDeathClaim
{
    public int Id { get; set; }

    public string? PolicyNumber { get; set; }

    public string? TypeOfDeath { get; set; }

    public string? NameOfDeceased { get; set; }

    public DateOnly? DateOfDeath { get; set; }

    public string? TimeOfDeath { get; set; }

    public string? PlaceOfDeath { get; set; }

    public string? CauseOfDeath { get; set; }

    public string? LastAddressOfDeceased { get; set; }

    public string? NameOfNominee { get; set; }

    public string? PresentContractAddressOfNominee { get; set; }

    public int? MobileNoOfNominee { get; set; }

    public string? BankNameOfNominee { get; set; }

    public string? BankAcnoOfNominee { get; set; }

    public string? BankBranchName { get; set; }

    public string? NameOfClaimant { get; set; }

    public string? RelationshipOfClaimantWithNominee { get; set; }

    public string? BlankCheckOrBankStatementFileName { get; set; }

    public string? DeathCertificate { get; set; }

    public string? LocalGovtDeathCertificate { get; set; }

    public string? AgeProofOfNomineeOrClaimant { get; set; }

    public string? OriginalPolicyDocument { get; set; }

    public string? AccidentalDeathCertificate { get; set; }

    public string? FirReport { get; set; }

    public string? PostMortemReportOrWaiverCertificate { get; set; }

    public string? AccidentalOriginalPolicyDocument { get; set; }

    public string? AbroadDeathCertificate { get; set; }

    public string? StateOfAffair { get; set; }

    public string? MinistryOfInterior { get; set; }

    public string? Noc { get; set; }

    public string? Passport { get; set; }

    public string? EmploymentCertificate { get; set; }

    public string? AirwayBillOrDocument { get; set; }

    public string? AbroadOriginalPolicyDocument { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CrerateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
