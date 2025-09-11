using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class SalaryCalculation
{
    public int CalSalId { get; set; }

    public int? EmpId { get; set; }

    public int? BranchId { get; set; }

    public int? DepartmentId { get; set; }

    public int? DesignationId { get; set; }

    public int? PayscaleId { get; set; }

    public double? ComTrainingMarks { get; set; }

    public double? Experience { get; set; }

    public string? EducationalQualification { get; set; }

    public double? ExtraPackage { get; set; }

    public double? GrossSalary { get; set; }

    public double? Increment { get; set; }

    public int? IncrementCounter { get; set; }

    public double? AdditionalAllowance { get; set; }

    public double? PayscaleGross { get; set; }

    public double? IncrementRate { get; set; }

    public double? Tax { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
