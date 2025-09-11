using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class MotorExpense
{
    public int MotorExpenseId { get; set; }

    public string? LicenseNo { get; set; }

    public string? Reason { get; set; }

    public DateOnly? ExpenseDate { get; set; }

    public string? PayTo { get; set; }

    public double? Amount { get; set; }

    public string? Comments { get; set; }

    public int? BranchCode { get; set; }

    public string? Createby { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? AgentId { get; set; }
}
