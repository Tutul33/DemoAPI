using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AmOdoMeter
{
    public int Mvid { get; set; }

    public long? AssetTypeId { get; set; }

    public int? AssetMasterId { get; set; }

    public int? AssetNameId { get; set; }

    public string? RegistrationNo { get; set; }

    public double? OdoMeterReading { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
