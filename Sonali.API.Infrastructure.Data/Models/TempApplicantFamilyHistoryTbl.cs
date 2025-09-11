using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TempApplicantFamilyHistoryTbl
{
    public string? UniqueNumber { get; set; }

    public string? Relation { get; set; }

    public string? LifeStatus { get; set; }

    public string? Fhage { get; set; }

    public string? CurrPhysicalStatus { get; set; }

    public string? AgeDuringDeath { get; set; }

    public string? DeathReason { get; set; }

    public string? DurationOfIllness { get; set; }

    public string? YearOfDeath { get; set; }

    public int Id { get; set; }
}
