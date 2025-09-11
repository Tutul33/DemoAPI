using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class RankingPrOr
{
    public string Agent { get; set; } = null!;

    public string? AgentType { get; set; }

    public string Branch { get; set; } = null!;

    public string? BankName { get; set; }

    public string? AccountNo { get; set; }

    public string Samd { get; set; } = null!;

    public int? TotalNoOfPolicies { get; set; }

    public double? TotalPremium { get; set; }

    public double? TotalCommission { get; set; }

    public double? TotalAit { get; set; }

    public int? AgentId { get; set; }

    public DateTime? CreateDate { get; set; }
}
