using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class EmpBusinessPerformance
{
    public int BusinessId { get; set; }

    public int? EmpId { get; set; }

    public int? AgentId { get; set; }

    public double? Jan { get; set; }

    public double? Feb { get; set; }

    public double? March { get; set; }

    public double? April { get; set; }

    public double? May { get; set; }

    public double? June { get; set; }

    public double? July { get; set; }

    public double? Aug { get; set; }

    public double? Sep { get; set; }

    public double? Oct { get; set; }

    public double? Nov { get; set; }

    public double? Dec { get; set; }

    public double? Avg { get; set; }

    public int? Year { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
