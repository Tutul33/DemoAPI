using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ModePerfSchedule
{
    public decimal Id { get; set; }

    public string? ProcName { get; set; }

    public DateTime? RunAt { get; set; }

    public DateTime? Perf1 { get; set; }

    public DateTime? Perf2 { get; set; }

    public DateTime? Perf3 { get; set; }

    public decimal? Amt { get; set; }
}
