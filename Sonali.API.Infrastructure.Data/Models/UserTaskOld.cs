using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class UserTaskOld
{
    public int TaskId { get; set; }

    public string? UserName { get; set; }

    public int? RelationId { get; set; }

    public string? CaseType { get; set; }

    public string? Commence { get; set; }

    public int? CuStatus { get; set; }

    public string? Notes { get; set; }

    public double? Amount { get; set; }

    public DateOnly? ActDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? ReadFlag { get; set; }
}
