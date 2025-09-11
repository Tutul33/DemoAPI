using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class EmpIncrement
{
    public int IncrementId { get; set; }

    public int? EmpId { get; set; }

    public int? NoOfIncrement { get; set; }

    public double? IncrementAmount { get; set; }

    public DateOnly? IncrementDate { get; set; }

    public double? Percentage { get; set; }

    public string? Comment { get; set; }

    public int? Flag { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }
}
