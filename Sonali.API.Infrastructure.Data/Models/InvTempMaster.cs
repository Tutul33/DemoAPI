using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class InvTempMaster
{
    public int Sl { get; set; }

    public int? NameId { get; set; }

    public string? Name { get; set; }

    public int? Quantity { get; set; }

    public double? AvgCost { get; set; }

    public double? TotalCost { get; set; }

    public double? AvgCommission { get; set; }

    public double? TotalCommission { get; set; }

    public double? TotalCostAmount { get; set; }

    public double? MarketPrice { get; set; }

    public double? MarketValue { get; set; }

    public decimal? UnrealizedGain { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? Brok { get; set; }

    public string? UpdateDate { get; set; }
}
