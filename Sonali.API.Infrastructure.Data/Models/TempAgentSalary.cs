using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TempAgentSalary
{
    public int AgentSalaryId { get; set; }

    public int? AgentId { get; set; }

    public int? AgentTypeId { get; set; }

    public int? BranchId { get; set; }

    public double? TotalBusiness { get; set; }

    public double? BasicSalary { get; set; }

    public double? HouseRent { get; set; }

    public double? MobileBill { get; set; }

    public double? DevAllowance { get; set; }

    public double? Transport { get; set; }

    public double? OtherAllowance { get; set; }

    public double? TotalSalary { get; set; }

    public double? Tax { get; set; }

    public double? Deduction { get; set; }

    public string? DeductionDescription { get; set; }

    public double? NetSalary { get; set; }

    public DateOnly? PayDate { get; set; }

    public int? SalaryMonth { get; set; }

    public int? SalaryYear { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }
}
