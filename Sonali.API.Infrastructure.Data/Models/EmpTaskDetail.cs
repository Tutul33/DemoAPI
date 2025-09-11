using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class EmpTaskDetail
{
    public int TaskId { get; set; }

    public int? EmpId { get; set; }

    public int? DepartmentId { get; set; }

    public int? DesignationId { get; set; }

    public string? TaskDetail { get; set; }

    public DateOnly? TaskDate { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
