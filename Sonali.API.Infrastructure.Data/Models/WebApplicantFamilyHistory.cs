using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class WebApplicantFamilyHistory
{
    public int WebFamilyHistoryId { get; set; }

    public string WebApplicantDocId { get; set; } = null!;

    public string? Relation { get; set; }

    public string? LifeStatus { get; set; }

    public string? Age { get; set; }

    public string? CurrentPhysicalStatus { get; set; }

    public string? AgeDuringDeath { get; set; }

    public string? DeathReason { get; set; }

    public string? DurationOfLastIllness { get; set; }

    public string? YearOfDeath { get; set; }

    public int IsPolicy { get; set; }
}
