using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Eftndetail
{
    public decimal Id { get; set; }

    public int? Fprid { get; set; }

    public DateOnly? DueDate { get; set; }

    public double? Amt { get; set; }

    public string? Eftnstatus { get; set; }

    public string? Remarks { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
