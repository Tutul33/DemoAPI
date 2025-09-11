using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class EmpErp
{
    public int Erpid { get; set; }

    public int? EmpId { get; set; }

    public double? Erpjan { get; set; }

    public double? Erpfeb { get; set; }

    public double? Erpmarch { get; set; }

    public double? Erpapril { get; set; }

    public double? Erpmay { get; set; }

    public double? Erpjune { get; set; }

    public double? Erpjuly { get; set; }

    public double? Erpaug { get; set; }

    public double? Erpsep { get; set; }

    public double? Erpoct { get; set; }

    public double? Erpnov { get; set; }

    public double? Erpdec { get; set; }

    public double? Erpavg { get; set; }

    public int? Year { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }
}
