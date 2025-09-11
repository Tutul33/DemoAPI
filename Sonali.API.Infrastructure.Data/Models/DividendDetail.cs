using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class DividendDetail
{
    public decimal Sl { get; set; }

    public decimal? Brokerage { get; set; }

    public int? NameId { get; set; }

    public DateOnly? RecordDate { get; set; }

    public int SharesHeld { get; set; }

    public decimal? FaceValue { get; set; }

    public decimal ShareRate { get; set; }

    public decimal? SharePer { get; set; }

    public decimal ShareQty { get; set; }

    public DateOnly? ShareRecDate { get; set; }

    public decimal? CashPer { get; set; }

    public double CashAmt { get; set; }

    public DateOnly? CashRecDate { get; set; }

    public DateOnly? ReceivedDate { get; set; }

    public decimal? BankAc { get; set; }

    public string? Comments { get; set; }

    public string? Ait { get; set; }

    public DateOnly? BankDepDate { get; set; }
}
