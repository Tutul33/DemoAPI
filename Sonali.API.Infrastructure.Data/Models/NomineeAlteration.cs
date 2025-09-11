using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class NomineeAlteration
{
    public int NomineeAlterationId { get; set; }

    public int? Fprid { get; set; }

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

    public int? NomineeCurrStatus { get; set; }

    public DateTime? AlterationReqDate { get; set; }

    public string? CreateBy { get; set; }
}
