using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PolicyApplicantsFamilyHistory
{
    public int FamilyHistoryId { get; set; }

    public int ApplicantId { get; set; }

    public string? Relation { get; set; }

    public string? LifeStatus { get; set; }

    public string? Age { get; set; }

    public string? CurrentPhysicalStatus { get; set; }

    public string? AgeDuringDeath { get; set; }

    public string? DeathReason { get; set; }

    public string? DurationOfLastIllness { get; set; }

    public string? YearOfDeath { get; set; }

    public int IsRemoved { get; set; }

    public virtual PolicyApplicantsPersonalInfo Applicant { get; set; } = null!;
}
