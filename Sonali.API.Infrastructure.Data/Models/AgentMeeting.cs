using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentMeeting
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? MeetingTime { get; set; }

    public string? Contract { get; set; }

    public string? Location { get; set; }

    public string? Comments { get; set; }

    public int? AgentId { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateOnly? MeetingDate { get; set; }
}
