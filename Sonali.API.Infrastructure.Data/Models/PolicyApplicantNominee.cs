using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PolicyApplicantNominee
{
    public int NomineeId { get; set; }

    public int? ApplicantId { get; set; }

    public string? NomineeName { get; set; }

    public string? NomineeAge { get; set; }

    public string? NomineeRelation { get; set; }

    public string? NomineeAllocation { get; set; }

    public string? DocumentType { get; set; }

    public string? UploadDocument { get; set; }

    public string? NomineePpname { get; set; }

    public string? NomineeGuardianName { get; set; }

    public string? GuardianAddress { get; set; }

    public string? NomineeDob { get; set; }

    public string? LegalGuardianRelation { get; set; }

    public string? LegalGuardianNidno { get; set; }

    public string? LegalGuardianNidphoto { get; set; }

    public string? LegalGuardianPhoto { get; set; }

    public string? DocumentId { get; set; }
}
