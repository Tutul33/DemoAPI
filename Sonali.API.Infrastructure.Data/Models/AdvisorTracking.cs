using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AdvisorTracking
{
    public int Id { get; set; }

    public string? Dob { get; set; }

    public int? Age { get; set; }

    public int? PolicyId { get; set; }

    public int? Duration { get; set; }

    public int? InstallmentType { get; set; }

    public int? SupplementaryId { get; set; }

    public string? PolicyRiskCategory { get; set; }

    public double? TotalPolicyAmount { get; set; }

    public double? BasicPremium { get; set; }

    public double? SupplementaryPremium { get; set; }

    public double? TotalPremium { get; set; }

    public string? TrackingCode { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? ClientName { get; set; }

    public string? ClientAddress { get; set; }

    public string? PhoneNo { get; set; }

    public string? LifeStage { get; set; }

    public int? CreateByAgentId { get; set; }

    public string? CreateByAgentType { get; set; }

    public string? StatusFlag { get; set; }
}
