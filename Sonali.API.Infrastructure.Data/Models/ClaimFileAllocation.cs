using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ClaimFileAllocation
{
    public int Id { get; set; }

    public int? LeaderId { get; set; }

    public int? MemberId { get; set; }

    public string? ClaimType { get; set; }

    public int? FprId { get; set; }

    public int? InsNo { get; set; }

    public DateOnly? MaturityDate { get; set; }

    public DateOnly? AllocationDate { get; set; }

    public DateOnly? ApproveDate { get; set; }

    public DateOnly? PaidDate { get; set; }

    public int? Flag { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
