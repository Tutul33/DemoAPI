using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class GtliclaimSettlement
{
    public int GtlisettlementId { get; set; }

    public int? GtliclaimId { get; set; }

    public int? Gtliid { get; set; }

    public string? CompanyName { get; set; }

    public int? SerialNumber { get; set; }

    public string? RegistrationNumber { get; set; }

    public string? DeathSummary { get; set; }

    public string? ClaimInvestigation { get; set; }

    public string? ClaimCommMemberName { get; set; }

    public string? DecisionofClaimCommittee { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
