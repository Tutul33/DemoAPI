using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TmpAccChart
{
    public int Sl { get; set; }

    public string? VoucherNo { get; set; }

    public string? ActCode { get; set; }

    public string? ActName { get; set; }

    public decimal? Damount { get; set; }

    public decimal? Camount { get; set; }

    public decimal? Amt { get; set; }

    public string? Descrp { get; set; }

    public string? UserId { get; set; }

    public DateOnly? EntryDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Year { get; set; }
}
