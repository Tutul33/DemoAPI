using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ApplicationFileAllocation
{
    public int Id { get; set; }

    public int? LeaderId { get; set; }

    public int? MemberId { get; set; }

    public int? ApplicantId { get; set; }

    public int? Faid { get; set; }

    public int? Sgmid { get; set; }

    public int? AmdId { get; set; }

    public int? SamdId { get; set; }

    public DateOnly? AllocationDate { get; set; }

    public DateOnly? ApplicationDate { get; set; }

    public DateOnly? PrDate { get; set; }

    public DateOnly? SummaryDate { get; set; }

    public DateOnly? MedicalExaminationDate { get; set; }

    public DateOnly? MedicalAuthorizationDate { get; set; }

    public DateOnly? FprDate { get; set; }

    public string? FileType { get; set; }

    public int? Flag { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
