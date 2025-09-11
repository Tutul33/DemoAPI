using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Policy10SvpaidUpRate
{
    public int Id { get; set; }

    public int? RetirementAge { get; set; }

    public int? ActualAge { get; set; }

    public int? PolicyNthYear { get; set; }

    public string? RateType { get; set; }

    public double? Rate { get; set; }
}
