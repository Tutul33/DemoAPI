using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class CheckInOut
{
    public int Sl { get; set; }

    public int? UserId { get; set; }

    public DateTime? CheckTime { get; set; }
}
