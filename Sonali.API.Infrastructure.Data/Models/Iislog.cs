using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Iislog
{
    public long LogId { get; set; }

    public DateOnly? Date { get; set; }

    public TimeOnly? Time { get; set; }

    public string? ClientIp { get; set; }

    public string? UserName { get; set; }

    public string? ServerIpaddress { get; set; }

    public string? ServerPort { get; set; }

    public string? Method { get; set; }

    public string? UriStrem { get; set; }

    public string? UriQuery { get; set; }

    public int? ProtocolStatus { get; set; }

    public int? ProtocolSubStatus { get; set; }

    public long? Win32Status { get; set; }

    public int? TimeTaken { get; set; }

    public string? UserAgent { get; set; }

    public string? Referer { get; set; }
}
