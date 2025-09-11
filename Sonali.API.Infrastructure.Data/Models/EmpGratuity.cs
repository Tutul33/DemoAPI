using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class EmpGratuity
{
    public int Sl { get; set; }

    public int? EmpId { get; set; }

    public int? DesignationId { get; set; }

    public int? DeptId { get; set; }

    public DateOnly? JobStartDate { get; set; }

    public DateOnly? JobEndDate { get; set; }

    public string? JobDuration { get; set; }

    public int? CalcDuration { get; set; }

    public double? GrossSalary { get; set; }

    public double? GratuityAmount { get; set; }

    public int? Flag { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? PaidDate { get; set; }
}
