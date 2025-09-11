using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ProcurementMaster
{
    public int Id { get; set; }

    public string? Status { get; set; }

    public string? FileName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }
}
