using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ProcessWithCode
{
    public int Id { get; set; }

    public string? ProcessName { get; set; }

    public string? Statas { get; set; }

    public string? AgentType { get; set; }

    public string? DrCode { get; set; }

    public string? CrCode { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Flag { get; set; }
}
