using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class VehicleMaintenance
{
    public int VehicleMaintenanceId { get; set; }

    public string? RegistationNo { get; set; }

    public string? Reason { get; set; }

    public double? Amount { get; set; }

    public int? StatusFlag { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
