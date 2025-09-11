using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PayScale
{
    public int PayScaleId { get; set; }

    public string? DesignationName { get; set; }

    public string? Scale { get; set; }

    public double? GrossSalary { get; set; }

    public double? IncrementRate { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
