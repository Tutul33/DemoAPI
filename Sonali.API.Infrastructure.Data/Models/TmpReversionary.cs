using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TmpReversionary
{
    public decimal Sl { get; set; }

    public int? Year { get; set; }

    public decimal? BonusAmt { get; set; }

    public int? ProductId { get; set; }

    public int? StartDuration { get; set; }

    public int? EndDuration { get; set; }

    public string? User { get; set; }
}
