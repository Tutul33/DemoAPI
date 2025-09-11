using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AssetSale
{
    public int SalesId { get; set; }

    public string? TypeName { get; set; }

    public string? CodeNo { get; set; }

    public int? ItemId { get; set; }

    public int? SalesGroupId { get; set; }

    public double? SalesPrice { get; set; }

    public int? SalesStatus { get; set; }

    public DateOnly? SaleDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public double? ValueAfterDep { get; set; }
}
