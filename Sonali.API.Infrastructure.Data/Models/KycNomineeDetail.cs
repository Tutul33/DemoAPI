using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class KycNomineeDetail
{
    public int Sl { get; set; }

    public int? KycmasterId { get; set; }

    public int? ApplicantId { get; set; }

    public string? NomineeName { get; set; }

    public string? Relation { get; set; }

    public string? NomFatherName { get; set; }

    public string? NomMotherName { get; set; }

    public string? NomSpouseName { get; set; }

    public DateOnly? NomDob { get; set; }

    public string? NomOccupation { get; set; }

    public string? NomDocType { get; set; }

    public string? NomDocId { get; set; }

    public string? NomtelRes { get; set; }

    public string? NomTelOffice { get; set; }

    public string? NomFax { get; set; }

    public string? Nomemail { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public int? NomineeId { get; set; }

    public string? UploadDocument { get; set; }

    public string? NomineePpname { get; set; }
}
