using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TmpIislog
{
    public DateOnly? Date { get; set; }

    public TimeOnly? Time { get; set; }

    public string? SIp { get; set; }

    public string? CsMethod { get; set; }

    public string? CsUriStem { get; set; }

    public string? CsUriQuery { get; set; }

    public string? SPort { get; set; }

    public string? SUsername { get; set; }

    public string? CIp { get; set; }

    public string? CsUserAgent { get; set; }

    public string? CsReferer { get; set; }

    public int? ScStatus { get; set; }

    public int? ScSubstatus { get; set; }

    public long? ScWin32Status { get; set; }

    public int? TimeTaken { get; set; }
}
