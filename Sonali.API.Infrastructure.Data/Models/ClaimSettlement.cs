using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ClaimSettlement
{
    public int ClaimSettlementId { get; set; }

    public int? ClaimId { get; set; }

    public int? PolicyId { get; set; }

    public string? ClaimSummary { get; set; }

    public string? InvestigationSummary { get; set; }

    public string? ClaimComMemberName { get; set; }

    public string? DecisionofClaimCommittee { get; set; }

    public double? SuggestedAmount { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public double? Tax { get; set; }
}
