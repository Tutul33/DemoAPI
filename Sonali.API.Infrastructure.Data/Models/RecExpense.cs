using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class RecExpense
{
    public int RecExpId { get; set; }

    public string? Branch { get; set; }

    public int? ExpTypeId { get; set; }

    public string? ExpType { get; set; }

    public string? Comments { get; set; }

    public decimal? Amount { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? ExpPaid { get; set; }
}
