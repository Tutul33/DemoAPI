using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class SalaryAdjust2025
{
    public int Sl { get; set; }

    public int? EmpId { get; set; }

    public string? EmpName { get; set; }

    public double? PrevSal { get; set; }

    public double? CurSal { get; set; }

    public int? PayStatus { get; set; }
}
