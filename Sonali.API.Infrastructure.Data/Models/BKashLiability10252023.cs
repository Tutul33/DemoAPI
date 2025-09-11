using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class BKashLiability10252023
{
    public decimal Id { get; set; }

    public string? VoucherNo { get; set; }

    public string ActCode { get; set; } = null!;

    public decimal? Damount { get; set; }

    public decimal? Camount { get; set; }

    public string? AccStatement { get; set; }

    public string? Descrp { get; set; }

    public DateOnly? EntryDate { get; set; }

    public string? UserId { get; set; }

    public string TransactionNo { get; set; } = null!;

    public byte NoOfRows { get; set; }
}
