using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ClaimCourt
{
    public int? Sl { get; set; }

    public string? ClaimType { get; set; }

    public string? PolicyNo { get; set; }

    public string? CommencementDate { get; set; }

    public int? ClaimId { get; set; }

    public string? ClaimDate { get; set; }

    public decimal? ClaimAmount { get; set; }

    public string? DecisionDate { get; set; }

    public string? PaidDate { get; set; }

    public int? SettlementDuration1 { get; set; }

    public string? ClaimStatus { get; set; }

    public string? Comment { get; set; }

    public string? ClaimNotificationDate { get; set; }

    public string? OcfreceivingDate { get; set; }

    public int? Duration { get; set; }

    public int? SettlementDuration { get; set; }
}
