using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class SessionLoginHistory
{
    public int LogId { get; set; }

    public int Spid { get; set; }

    public DateTime LoginTime { get; set; }

    public DateTime? LogoutTime { get; set; }

    public string UserName { get; set; } = null!;

    public string? HostName { get; set; }

    public string? ProgramName { get; set; }

    public string? ClientNetAddress { get; set; }
}
