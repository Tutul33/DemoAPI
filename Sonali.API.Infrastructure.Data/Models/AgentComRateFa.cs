using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentComRateFa
{
    public int Id { get; set; }

    public int? ProductCategoryId { get; set; }

    public int? TermOfYears { get; set; }

    public double? Fyear { get; set; }

    public double? Syear { get; set; }

    public double? Tyear { get; set; }
}
