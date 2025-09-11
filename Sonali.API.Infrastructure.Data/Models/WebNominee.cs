using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class WebNominee
{
    public int WebNomineeId { get; set; }

    public string? WebApplicantDocId { get; set; }

    public int? NomineeSerial { get; set; }

    public string? NomineeName { get; set; }

    public string? NomineeAge { get; set; }

    public string? NomineeRelation { get; set; }

    public int? NomineeAllocation { get; set; }

    public string? DocumentType { get; set; }

    public string? UploadDocument { get; set; }

    public string? NomineePpname { get; set; }

    public string? NomineeGuardianName { get; set; }

    public string? GuardianAddress { get; set; }

    public string? LegalGuardianRelation { get; set; }

    public string? LegalGuardianNidno { get; set; }

    public string? LegalGuardianNidphoto { get; set; }

    public string? LegalGuardianPhoto { get; set; }

    public int IsPolicy { get; set; }

    public DateOnly? NomineeDob { get; set; }

    public string? DocumentId { get; set; }
}
