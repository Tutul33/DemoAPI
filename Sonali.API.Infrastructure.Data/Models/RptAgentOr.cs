using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class RptAgentOr
{
    public int Sl { get; set; }

    public int? AgentId { get; set; }

    public string? Agent { get; set; }

    public int? TotalNoPolicies { get; set; }

    public double? SumAssured { get; set; }

    public double? TotalPremiumReceived { get; set; }

    public double? TotalCommission { get; set; }

    public double? TotalVat { get; set; }

    public double? TotalNetCommission { get; set; }

    public double? NetRetention { get; set; }

    public int? DuePolicy { get; set; }

    public double? DueAmount { get; set; }

    public int? LapsePolicy { get; set; }

    public double? LapseAmount { get; set; }

    public int? Faid { get; set; }

    public int? Samdid { get; set; }

    public int? Umid { get; set; }

    public int? Bmid { get; set; }

    public int? Bcid { get; set; }

    public int? Dcid { get; set; }

    public int? Rcid { get; set; }

    public int? Dvcid { get; set; }

    public int? Sgmid { get; set; }

    public int? Amdid { get; set; }

    public string? UserName { get; set; }
}
