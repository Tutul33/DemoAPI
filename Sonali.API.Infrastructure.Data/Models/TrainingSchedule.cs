using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TrainingSchedule
{
    public int TrainingId { get; set; }

    public string? TrainingSubject { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public string? FromTime { get; set; }

    public string? ToTime { get; set; }

    public string? Venue { get; set; }

    public string? Trainer { get; set; }

    public string? ParticipantEmpId { get; set; }

    public string? ParticipantEmpName { get; set; }

    public string? ParticipantAgentId { get; set; }

    public string? ParticipantAgentName { get; set; }

    public string? UserName { get; set; }

    public int? Flag { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
