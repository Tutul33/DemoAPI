using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TblChart
{
    public int Id { get; set; }

    public string? Sgcode { get; set; }

    public string? Sgname { get; set; }

    public string? Gcode { get; set; }

    public string? Gname { get; set; }

    public double? OpBal { get; set; }

    public double? Dr { get; set; }

    public double? Cr { get; set; }

    public double? Bal { get; set; }
}
