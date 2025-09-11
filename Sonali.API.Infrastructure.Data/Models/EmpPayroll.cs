using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class EmpPayroll
{
    public int PayrollId { get; set; }

    public int? EmpId { get; set; }

    public int? BranchId { get; set; }

    public int? DepartmentId { get; set; }

    public int? DesigId { get; set; }

    public double? BasicSalary { get; set; }

    public double? HouseRent { get; set; }

    public double? HouseMaintanance { get; set; }

    public double? MedicalAllowance { get; set; }

    public double? Conveyance { get; set; }

    public double? AdvanceSalary { get; set; }

    public double? AdvanceRemain { get; set; }

    public double? AdvanceDeduct { get; set; }

    public double? AdvanceDeductPremium { get; set; }

    public double? AdvanceDeductPersonal { get; set; }

    public double? AdvanceDeductEmi { get; set; }

    public double? Bonus { get; set; }

    public double? Arrear { get; set; }

    public string? ArrearDescription { get; set; }

    public double? TotalSalary { get; set; }

    public double? Deduction { get; set; }

    public string? DeductionDescription { get; set; }

    public double? Tax { get; set; }

    public int? LateAttandance { get; set; }

    public double? DeductionForLate { get; set; }

    public int? Absent { get; set; }

    public double? DeductionForAbsent { get; set; }

    public double? LeaveWithoutPay { get; set; }

    public int? Otdays { get; set; }

    public double? Otamount { get; set; }

    public double? Allowance { get; set; }

    public double? PensionScheme { get; set; }

    public double? NetSalary { get; set; }

    public double? TakeHomePay { get; set; }

    public int? LeaveTaken { get; set; }

    public DateOnly? SalaryMonth { get; set; }

    public DateOnly? SalaryDate { get; set; }

    public int? Flag { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
