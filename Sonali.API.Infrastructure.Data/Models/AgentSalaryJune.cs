using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentSalaryJune
{
    public int Sl { get; set; }

    public int? AgentId { get; set; }

    public double? Amount { get; set; }

    public string? Purpose { get; set; }
}
