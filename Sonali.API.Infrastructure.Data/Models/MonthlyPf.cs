using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class MonthlyPf
{
    public int Id { get; set; }

    public int? Yr { get; set; }

    public int? Mon { get; set; }

    public string? Orstatus { get; set; }

    public string? AgentType { get; set; }

    public double? Amt { get; set; }
}
