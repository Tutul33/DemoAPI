using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class EmpDemerit
{
    public int Sl { get; set; }

    public int? EmpId { get; set; }

    public int? DeptId { get; set; }

    public double? DemeritPoints { get; set; }

    public double? NegativeMarks { get; set; }

    public int? Year { get; set; }

    public string? Comments { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
