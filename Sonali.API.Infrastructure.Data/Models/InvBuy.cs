using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class InvBuy
{
    public decimal Sl { get; set; }

    public string? ShareType { get; set; }

    public int NameId { get; set; }

    public int BoughtQuantity { get; set; }

    public double? CostPrice { get; set; }

    public double? FaceValue { get; set; }

    public double? BuyAmount { get; set; }

    public double? MarketRate { get; set; }

    public double? MarketValue { get; set; }

    public double? CommissionRate { get; set; }

    public double? CommissionAmount { get; set; }

    public string? PayMethod { get; set; }

    public string? Acname { get; set; }

    public string? AcBrok { get; set; }

    public DateOnly? PurchaseDate { get; set; }

    public string? Comments { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public string? Typ { get; set; }

    public string? BankActCode { get; set; }

    public string? BankActName { get; set; }

    public virtual InvCreateInvestment Name { get; set; } = null!;
}
