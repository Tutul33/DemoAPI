using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AdvancedAgainstExp
{
    public decimal Sl { get; set; }

    public int? NameId { get; set; }

    public string? Iuno { get; set; }

    public string? Purpose { get; set; }

    public string TransactionType { get; set; } = null!;

    public decimal ExpenseType { get; set; }

    public double Amount { get; set; }

    public string? Payment { get; set; }

    public double AdjustAmount { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? Com { get; set; }

    public string? Vno { get; set; }
}
