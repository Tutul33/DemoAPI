using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class BonusRevDetail
{
    public decimal RevDetailId { get; set; }

    public decimal? RevId { get; set; }

    public int? Year { get; set; }

    public decimal? BonusAmt { get; set; }

    public int? ProductId { get; set; }

    public int? StartDuration { get; set; }

    public int? EndDuration { get; set; }
}
