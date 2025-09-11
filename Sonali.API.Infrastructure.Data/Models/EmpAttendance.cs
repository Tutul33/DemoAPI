using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class EmpAttendance
{
    public int AttendanceId { get; set; }

    public int? EmpId { get; set; }

    public double? AttJan { get; set; }

    public double? AttFeb { get; set; }

    public double? AttMarch { get; set; }

    public double? AttApril { get; set; }

    public double? AttMay { get; set; }

    public double? AttJune { get; set; }

    public double? AttJuly { get; set; }

    public double? AttAug { get; set; }

    public double? AttSep { get; set; }

    public double? AttOct { get; set; }

    public double? AttNov { get; set; }

    public double? AttDec { get; set; }

    public double? AttAvg { get; set; }

    public int? Year { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }
}
