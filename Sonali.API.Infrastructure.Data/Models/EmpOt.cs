using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class EmpOt
{
    public int Sl { get; set; }

    public int? EmpId { get; set; }

    public DateOnly? Otdate { get; set; }

    public double? Otamount { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
