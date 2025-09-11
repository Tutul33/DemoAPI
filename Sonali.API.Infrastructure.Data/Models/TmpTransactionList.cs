using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TmpTransactionList
{
    public int Id { get; set; }

    public string TransactionNo { get; set; } = null!;

    public string? MonthOfYear { get; set; }

    public short? Year { get; set; }

    public byte? IsDone { get; set; }
}
