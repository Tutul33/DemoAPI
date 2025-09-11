using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AssigneeInformation
{
    public int AssigneeId { get; set; }

    public string? AssigneeName { get; set; }

    public string? PermanentAddress { get; set; }

    public string? ChooseDocuments { get; set; }

    public string? UploadDocs { get; set; }

    public string? IdNumber { get; set; }

    public string? UploadPp { get; set; }

    public string? PresentAddress { get; set; }

    public string? EmailAddress { get; set; }

    public string? MobileNo { get; set; }

    public int? Fprid { get; set; }

    public int? ApplicantId { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
