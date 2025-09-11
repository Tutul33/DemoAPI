using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ClaimInvestigation
{
    public int ClaimInvestigationId { get; set; }

    public int? PolicyId { get; set; }

    public int? ClaimId { get; set; }

    public int? EmpId { get; set; }

    public string? IntervieweeName { get; set; }

    public string? IntervieweeAddress { get; set; }

    public string? IntervieweeComments { get; set; }

    public string? IntervieweeContact { get; set; }

    public DateOnly? IntervieweeDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
