using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentMonthlyTarget
{
    public int TargetId { get; set; }

    public int? AgentId { get; set; }

    public string? AgentType { get; set; }

    public int? BranchId { get; set; }

    public string? TargetMonth { get; set; }

    public int? TargetYear { get; set; }

    public double? TargetAmount { get; set; }

    public double? AchievedAmount { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
