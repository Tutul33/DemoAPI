using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class InvSell
{
    public decimal SellId { get; set; }

    public int NameId { get; set; }

    public double CostPrice { get; set; }

    public double MarketPrice { get; set; }

    public int SoldQuantity { get; set; }

    public double? SoldAmount { get; set; }

    public double? CommissionRate { get; set; }

    public double? CommissionAmount { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public double? BuyCommission { get; set; }

    public double? AvgSellCommission { get; set; }

    public double? ConsAvgCost { get; set; }

    public decimal? RemainingQty { get; set; }

    public string? AcBrok { get; set; }

    public virtual InvCreateInvestment Name { get; set; } = null!;
}
