using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class FileAllocTemp
{
    public int Sl { get; set; }

    public int? LeaderId { get; set; }

    public int? MemberId { get; set; }

    public int? ApplicantId { get; set; }

    public DateOnly? ApplicationDate { get; set; }

    public DateOnly? PrBmDate { get; set; }

    public int? Faid { get; set; }

    public int? Sgmid { get; set; }

    public int? AmdId { get; set; }

    public int? Samdid { get; set; }

    public string? FileType { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
