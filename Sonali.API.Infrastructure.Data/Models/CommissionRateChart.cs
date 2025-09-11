using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class CommissionRateChart
{
    public int Id { get; set; }

    public string? TermOfYear { get; set; }

    public double? Fa { get; set; }

    public double? Um1 { get; set; }

    public double? Bm1 { get; set; }

    public double? Gm { get; set; }

    public double? Dgm { get; set; }

    public double? Agm { get; set; }

    public double? Total { get; set; }
}
