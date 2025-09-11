using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AssetMaintenance
{
    public int MaintenId { get; set; }

    public string? TypeName { get; set; }

    public string? CodeNo { get; set; }

    public int? ItemId { get; set; }

    public int? MaintenGroupId { get; set; }

    public int? MainStatus { get; set; }

    public string? Notes { get; set; }

    public int? Branch { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
