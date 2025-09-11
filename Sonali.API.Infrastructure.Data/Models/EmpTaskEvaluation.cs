using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class EmpTaskEvaluation
{
    public int TaskId { get; set; }

    public int? EmpId { get; set; }

    public int? BranchId { get; set; }

    public int? DeptId { get; set; }

    public int? DesigId { get; set; }

    public string? TaskDetail { get; set; }

    public string? TaskDetailDone { get; set; }

    public string? TaskNotDoneDetail { get; set; }

    public string? TaskDetailNotReq { get; set; }

    public double? TotalTask { get; set; }

    public int? TaskDone { get; set; }

    public int? TaskNotDone { get; set; }

    public int? TaskNotReq { get; set; }

    public double? Percentage { get; set; }

    public DateOnly? TaskDate { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }
}
