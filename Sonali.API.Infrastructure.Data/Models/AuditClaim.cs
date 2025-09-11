using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AuditClaim
{
    public int Sl { get; set; }

    public string? ClaimType { get; set; }

    public string? PolicyNo { get; set; }

    public string? CommencementDate { get; set; }

    public int? ClaimId { get; set; }

    public DateTime? ClaimDate { get; set; }

    public double? ClaimAmount { get; set; }

    public string DecisionDate { get; set; } = null!;

    public string? PaidDate { get; set; }

    public string SettlementDuration1 { get; set; } = null!;

    public string ClaimStatus { get; set; } = null!;

    public string Comment { get; set; } = null!;

    public string? ClaimNotificationDate { get; set; }

    public string? OcfreceivingDate { get; set; }

    public int? Duration { get; set; }

    public int? SettlementDuration { get; set; }
}
