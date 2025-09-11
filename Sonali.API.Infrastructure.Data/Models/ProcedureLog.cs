using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ProcedureLog
{
    public int LogId { get; set; }

    public int? DatabaseId { get; set; }

    public string? DatabaseName { get; set; }

    public int? ObjectId { get; set; }

    public string? ProcedureName { get; set; }

    public int? ErrorLine { get; set; }

    public string? ErrorMessage { get; set; }

    public string? AdditionalInfo { get; set; }

    public DateTime LogDate { get; set; }
}
