using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TourBudget
{
    public int TourBudgetId { get; set; }

    public int? TourId { get; set; }

    public int? EmpId { get; set; }

    public int? AgentId { get; set; }

    public double? Amount { get; set; }

    public int? Flag { get; set; }

    public DateOnly? SanctionDate { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
