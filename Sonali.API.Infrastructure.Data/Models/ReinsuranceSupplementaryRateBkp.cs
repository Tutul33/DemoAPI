using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ReinsuranceSupplementaryRateBkp
{
    public int ReinsuranceSuppId { get; set; }

    public int? SupplementaryId { get; set; }

    public string? Class { get; set; }

    public double? Rate { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public string? ReinsuranceType { get; set; }
}
