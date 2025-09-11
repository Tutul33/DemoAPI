using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class LeaveManagement
{
    public int LeaveId { get; set; }

    public int EmpId { get; set; }

    public string BranchName { get; set; } = null!;

    public int? CasualLeave { get; set; }

    public int? EarnedLeave { get; set; }

    public int? LeaveTaken { get; set; }

    public int? CasualRemain { get; set; }

    public int? EarnedRemain { get; set; }

    public DateOnly? LeaveFromDate { get; set; }

    public DateOnly? LeaveToDate { get; set; }

    public string? Status { get; set; }

    public string? Description { get; set; }

    public string? LeaveType { get; set; }

    public int? Flag { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
