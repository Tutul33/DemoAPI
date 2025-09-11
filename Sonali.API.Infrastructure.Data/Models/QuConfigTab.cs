using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class QuConfigTab
{
    public int Id { get; set; }

    public string? JobName { get; set; }

    public string? JobStatus { get; set; }

    public int? SelectTop { get; set; }

    public string? WaitDelay { get; set; }
}
