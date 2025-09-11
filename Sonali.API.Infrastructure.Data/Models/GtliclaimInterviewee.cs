using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class GtliclaimInterviewee
{
    public int IntervieweeId { get; set; }

    public string? IntervieweeName { get; set; }

    public string? IntervieweeAddress { get; set; }

    public string? IntervieweeComments { get; set; }

    public string? IntervieweeContact { get; set; }

    public DateTime? IntervieweeDate { get; set; }

    public int? Gtliid { get; set; }

    public int? ClaimId { get; set; }

    public int? GtliclaimInvestigationId { get; set; }
}
