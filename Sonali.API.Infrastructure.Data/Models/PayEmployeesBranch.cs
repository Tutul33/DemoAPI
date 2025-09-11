using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PayEmployeesBranch
{
    public int BranchId { get; set; }

    public string? BranchIdno { get; set; }

    public string? BranchName { get; set; }

    public DateOnly? BranchCreateDate { get; set; }

    public string? BranchType { get; set; }

    public double? Amount { get; set; }

    public string? Decoration { get; set; }

    public string? BranchAddress { get; set; }

    public string? AgentType { get; set; }

    public int? BranchIncharge { get; set; }

    public double Itcost { get; set; }

    public string? BranchContactNumber { get; set; }

    public double BasicAmount { get; set; }

    public double AdvanceAmount { get; set; }

    public double MonthlySalary { get; set; }

    public double MonthlyExpense { get; set; }

    public string? LandLordName { get; set; }

    public string? LandLordMobile { get; set; }

    public string? LandLordBankName { get; set; }

    public string? LandLordAccNo { get; set; }

    public string? LandLordContractDoc { get; set; }

    public string? LandLordNic { get; set; }

    public string? LandLordNicdoc { get; set; }

    public double? AdvanceAdjustment { get; set; }

    public string? LicenseNo { get; set; }

    public double? LicenseFee { get; set; }

    public DateOnly? ContractFromDate { get; set; }

    public DateOnly? ContractToDate { get; set; }

    public string? BranchStatus { get; set; }

    public string? ProposedApproved { get; set; }

    public DateOnly? BranchCloseDate { get; set; }

    public string? Division { get; set; }

    public int? DistrictId { get; set; }

    public int? ThanaId { get; set; }

    public int? UnionId { get; set; }

    public int? Flag { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? AdvanceAcc { get; set; }

    public string? Comments { get; set; }

    public string? MapLocation { get; set; }
}
