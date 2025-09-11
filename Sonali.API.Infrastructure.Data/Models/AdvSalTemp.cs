using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AdvSalTemp
{
    public int AdvanceId { get; set; }

    public int? EmpId { get; set; }

    public double? Amount { get; set; }

    public DateOnly? ApplicationDate { get; set; }

    public DateOnly? TakenDate { get; set; }

    public string? Reason { get; set; }

    public int? RepayAmount { get; set; }

    public int? RepayPercent { get; set; }

    public double? Remaining { get; set; }

    public int? AdvanceType { get; set; }

    public string? Status { get; set; }

    public int? Flag { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? Comments { get; set; }
}
