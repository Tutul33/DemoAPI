using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class MeetingSchedule
{
    public int MeetingId { get; set; }

    public DateOnly? MeetingDate { get; set; }

    public string? MeetingTime { get; set; }

    public string? Agenda { get; set; }

    public string? Venue { get; set; }

    public string? ParticipantEmp { get; set; }

    public string? ParticipantAgent { get; set; }

    public string? Recur { get; set; }

    public string? UserName { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }
}
