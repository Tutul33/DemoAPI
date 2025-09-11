using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class RecAssetStock
{
    public int RecId { get; set; }

    public string? AssetDeseription { get; set; }

    public int? Quantity { get; set; }

    public double? NetAmount { get; set; }

    public double? TotalAmount { get; set; }

    public string? Branch { get; set; }

    public string? Comments { get; set; }

    public int? StatusFlag { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
