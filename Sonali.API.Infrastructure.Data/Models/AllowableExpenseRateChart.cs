using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AllowableExpenseRateChart
{
    public int Id { get; set; }

    public double? PlanId { get; set; }

    public double? TermOfYear { get; set; }

    public double? AllowableExpenseAgency { get; set; }

    public double? AllowableExpenseMgmt { get; set; }

    public double? TotalAllowableExpense { get; set; }

    public double? AllowableAtActual { get; set; }

    public string? Remarks { get; set; }
}
