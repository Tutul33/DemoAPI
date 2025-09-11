using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AssetStock
{
    public int Sl { get; set; }

    public int? AssetTypeId { get; set; }

    public int? AssetNameId { get; set; }

    public string? AssetName { get; set; }

    public int? Quantity { get; set; }

    public int? RemQuantity { get; set; }

    public double? NetAmount { get; set; }

    public double? TotalAmount { get; set; }

    public DateOnly? PurchaseDate { get; set; }

    public double? DepRate { get; set; }

    public string? Branch { get; set; }

    public string? Comments { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? VoucherNo { get; set; }

    public string? EmpType { get; set; }

    public int? EmpId { get; set; }

    public string? CalcDone { get; set; }

    public DateOnly? DepCalulatedToDate { get; set; }

    public double? LatestAdjustedPrice { get; set; }
}
