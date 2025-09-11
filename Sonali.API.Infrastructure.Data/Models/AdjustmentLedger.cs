using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AdjustmentLedger
{
    public int Id { get; set; }

    public string? Particular { get; set; }

    public string? TransactionType { get; set; }

    public double? Amount { get; set; }

    public DateOnly? EntryDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? ParticularType { get; set; }

    public string? StatusFlag { get; set; }
}
