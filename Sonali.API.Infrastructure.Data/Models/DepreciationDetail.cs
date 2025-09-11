using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class DepreciationDetail
{
    public decimal Id { get; set; }

    public int? StockId { get; set; }

    public DateOnly? PurchaseDt { get; set; }

    public DateOnly? DepDate { get; set; }

    public double? DepRate { get; set; }

    public double? CostBeforeDep { get; set; }

    public double? ThisDepAmt { get; set; }

    public double? CurrentCost { get; set; }
}
