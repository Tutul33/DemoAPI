using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentCalender
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? CalTime { get; set; }

    public int? PlannedCalls { get; set; }

    public int? ActualCalls { get; set; }

    public int? PlannedContacts { get; set; }

    public int? ActualContacts { get; set; }

    public int? PlannedPresentations { get; set; }

    public int? ActualPresentations { get; set; }

    public int? PlannedClosingInterviews { get; set; }

    public int? ActualClosingInterviews { get; set; }

    public int? AgentId { get; set; }

    public DateOnly? CalenderDate { get; set; }

    public DateTime? CraetedDate { get; set; }
}
