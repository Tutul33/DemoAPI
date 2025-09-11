using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AssetMaintenancePay
{
    public int MpayId { get; set; }

    public string? Mnotes { get; set; }

    public double? FeesAmount { get; set; }

    public int? MaintenId { get; set; }

    public int? PayStatus { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
