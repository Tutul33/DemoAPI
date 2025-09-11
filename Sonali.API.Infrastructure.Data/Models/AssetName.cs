using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AssetName
{
    public int Sl { get; set; }

    public int? AssetTypeId { get; set; }

    public string? AssetName1 { get; set; }

    public int? Resaleable { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
