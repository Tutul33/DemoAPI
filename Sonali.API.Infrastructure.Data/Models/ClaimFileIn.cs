using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ClaimFileIn
{
    public int InId { get; set; }

    public int? ReqId { get; set; }

    public string? Purpose { get; set; }

    public int? PolicyId { get; set; }

    public DateOnly? InDate { get; set; }

    public string? InBy { get; set; }

    public string? SubmittedTo { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? EmployeeId { get; set; }
}
