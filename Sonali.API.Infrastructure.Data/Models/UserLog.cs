using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class UserLog
{
    public decimal Sl { get; set; }

    public string? UserName { get; set; }

    public string? Pass { get; set; }

    public string? Ip { get; set; }

    public DateTime? Dt { get; set; }
}
