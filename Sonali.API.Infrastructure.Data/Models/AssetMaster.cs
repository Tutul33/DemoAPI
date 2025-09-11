using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AssetMaster
{
    public int MasterId { get; set; }

    public int? AssetTypeId { get; set; }

    public int? AssetNameId { get; set; }

    public int? Quantity { get; set; }

    public double? Amount { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
