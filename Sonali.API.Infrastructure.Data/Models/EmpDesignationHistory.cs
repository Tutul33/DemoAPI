using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class EmpDesignationHistory
{
    public int Sl { get; set; }

    public int? EmpId { get; set; }

    public int? DesignationId { get; set; }

    public int? SalMonth { get; set; }

    public int? SalYear { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
