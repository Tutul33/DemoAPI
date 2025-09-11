using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class LeaveSchedule
{
    public int ScheduleId { get; set; }

    public int? EmpId { get; set; }

    public string? BranchName { get; set; }

    public int? Casual { get; set; }

    public int? Earned { get; set; }

    public int? Maternity { get; set; }

    public int? Paternity { get; set; }

    public DateOnly? JobStartDate { get; set; }
}
