using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class DepreDetail
{
    public decimal Id { get; set; }

    public DateOnly? RecordDate { get; set; }

    public int? AssetMotorId { get; set; }

    public string? MotorName { get; set; }

    public int? AssetStockId { get; set; }

    public string? AssetName { get; set; }

    public string? RegNo { get; set; }

    public decimal? DepPerc { get; set; }

    public decimal? DepAmt { get; set; }

    public decimal? CumulativeDep { get; set; }

    public decimal? ValueRemain { get; set; }
}
