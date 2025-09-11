using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PensionSchemeMasterAgent
{
    public int Sl { get; set; }

    public int? AgentId { get; set; }

    public int? NoOfPf { get; set; }

    public double? TotalPfamt { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
