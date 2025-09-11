using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AlterationHistory
{
    public int AltHistoryId { get; set; }

    public int? Fprid { get; set; }

    public int? ApplicantId { get; set; }

    public string? PermanentAddress { get; set; }

    public string? PresentAddress { get; set; }

    public string? UploadDocsName { get; set; }

    public string? UploadDocsPhoto { get; set; }

    public string? UploadDocsId { get; set; }

    public string? UploadPhoto { get; set; }

    public int? ContactNo { get; set; }

    public int? AssigneeId { get; set; }

    public int? NomineeAlterationId1 { get; set; }

    public int? NomineeAlterationId2 { get; set; }

    public int? NomineeAlterationId3 { get; set; }

    public int? AltStatus { get; set; }

    public int? IsPaid { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
