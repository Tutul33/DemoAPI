using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ExpenditureDetail
{
    public int ExpEntryId { get; set; }

    public int? BranchId { get; set; }

    public double? Tada { get; set; }

    public double? VehicleMaintenance { get; set; }

    public double? OfficeExpenses { get; set; }

    public double? DevExpenses { get; set; }

    public double? Courier { get; set; }

    public double? MeetingExpenses { get; set; }

    public double? PolicyStamp { get; set; }

    public double? RevenueStamp { get; set; }

    public double? BankCharge { get; set; }

    public double? MedicalExpenses { get; set; }

    public double? OfficeStationery { get; set; }

    public double? NewspaperBill { get; set; }

    public double? EntertainmentBill { get; set; }

    public double? CleaningExpenses { get; set; }

    public double? MiscellaniesExpenses { get; set; }

    public double? UtilityBill { get; set; }

    public double? DevSalary { get; set; }

    public int? ExpenseYear { get; set; }

    public DateOnly? EntryDate { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
