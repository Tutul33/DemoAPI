using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class LogPayEmpJobDetail
{
    public int LogUserId { get; set; }

    public string? LogField { get; set; }

    public DateTime? LogDate { get; set; }

    public string? LogBy { get; set; }
}
