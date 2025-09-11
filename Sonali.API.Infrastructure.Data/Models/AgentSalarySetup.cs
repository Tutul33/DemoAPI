using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentSalarySetup
{
    public int Sl { get; set; }

    public string? FromAgentType { get; set; }

    public int? FromAgentId { get; set; }

    public string? ToAgentType { get; set; }

    public int? ToAgentId { get; set; }

    public string? FromAgentBusinessType { get; set; }

    public int? FromAgentBusinessId { get; set; }

    public double? Percentage { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
