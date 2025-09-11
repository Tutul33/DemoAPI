using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PushPullLog
{
    public int Sl { get; set; }

    public string? Type { get; set; }

    public string? Value { get; set; }

    public string? MobileNumber { get; set; }

    public string? Msg { get; set; }

    public DateTime? CreateDate { get; set; }

    public int Flag { get; set; }

    public string? ReadBy { get; set; }

    public DateTime? ReadDate { get; set; }
}
