using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class RptLapseSamd
{
    public int Sl { get; set; }

    public string? Fprid { get; set; }

    public double? TotalPremium { get; set; }

    public int? AgentId { get; set; }

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
