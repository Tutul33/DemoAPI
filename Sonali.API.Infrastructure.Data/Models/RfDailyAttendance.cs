using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class RfDailyAttendance
{
    public long Sl { get; set; }

    public long? Rfid { get; set; }

    public string? SensorId { get; set; }

    public string? UserType { get; set; }

    public int? UserId { get; set; }

    public int? BranchId { get; set; }

    public DateTime? LogInTime { get; set; }

    public DateTime? LogOutTime { get; set; }

    public double? ActiveMin { get; set; }

    public double? LateMin { get; set; }
}
