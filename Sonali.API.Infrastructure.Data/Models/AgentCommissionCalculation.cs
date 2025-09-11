using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentCommissionCalculation
{
    public int Id { get; set; }

    public int? AgentId { get; set; }

    public string? AgentName { get; set; }

    public string? AgentTypeName { get; set; }

    public int? BranchId { get; set; }

    public string? BranchName { get; set; }

    public int? NumberOfPolicy { get; set; }

    public double? PremiumAmount { get; set; }

    public double? BasicComAmount { get; set; }

    public double? SupComAmount { get; set; }

    public double? AitAmount { get; set; }

    public double? TotalCommissionAmount { get; set; }

    public double? NetRetention { get; set; }

    public string? OtherInfoSt { get; set; }

    public int? OtherInfoInt { get; set; }

    public string? UserName { get; set; }

    public string? AgentAccNo { get; set; }

    public int? JobDuration { get; set; }
}
