using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AaccAdjust21
{
    public int Sl { get; set; }

    public string? St { get; set; }

    public string? Fprid { get; set; }

    public string? OrentryId { get; set; }

    public double? TotalPremiumAmount { get; set; }

    public string? PayDate { get; set; }

    public string? Typ { get; set; }

    public int Cleared { get; set; }
}
