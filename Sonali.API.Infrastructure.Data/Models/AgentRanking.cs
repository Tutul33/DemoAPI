using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentRanking
{
    public int Sl { get; set; }

    public int? AgentId { get; set; }

    public string? AgentName { get; set; }

    public int? BranchId { get; set; }

    public string? BranchName { get; set; }

    public string? AgentTypeName { get; set; }

    public int? Samdid { get; set; }

    public string? Samdname { get; set; }

    public int? NoOfPr { get; set; }

    public double? PremiumAmount { get; set; }

    public double? TotalCommission { get; set; }

    public double? VatAmount { get; set; }

    public double? NetRetention { get; set; }

    public double? AvgPre { get; set; }

    public string? AgentAccNo { get; set; }

    public int? JobDuration { get; set; }

    public string? ReportType { get; set; }

    public int? RankMonth { get; set; }

    public int? RankYear { get; set; }

    public DateOnly? RankDate { get; set; }
}
