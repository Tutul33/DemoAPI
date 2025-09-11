using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentTypeTarget
{
    public int AgentTypeTargetId { get; set; }

    public int? AgentTypeId { get; set; }

    public string? AgentTypeName { get; set; }

    public int? TargetYear { get; set; }

    public string? TargetMonth { get; set; }

    public double? TargetAmount { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }
}
