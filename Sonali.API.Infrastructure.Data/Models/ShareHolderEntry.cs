using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ShareHolderEntry
{
    public decimal Id { get; set; }

    public string? Name { get; set; }

    public DateOnly? Date { get; set; }

    public decimal? BuyQty { get; set; }

    public decimal? SellQty { get; set; }

    public decimal? CashQty { get; set; }

    public decimal? StockQty { get; set; }

    public decimal? Fv { get; set; }

    public decimal? TotalValue { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
