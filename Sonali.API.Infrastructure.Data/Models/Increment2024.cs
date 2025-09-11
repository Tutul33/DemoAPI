using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Increment2024
{
    public int Sl { get; set; }

    public int? EmpId { get; set; }

    public int? DeptId { get; set; }

    public int? DesignationId { get; set; }

    public double? GrossSalary { get; set; }

    public double? IncrementAmount { get; set; }

    public int? NoOfIncrements { get; set; }

    public double? IncrementRate { get; set; }
}
