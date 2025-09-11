using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ReinsurancePremiumRate
{
    public int Id { get; set; }

    public int? Age { get; set; }

    public double? Rate { get; set; }

    public string? Gender { get; set; }

    public string? ReinsuranceType { get; set; }
}
