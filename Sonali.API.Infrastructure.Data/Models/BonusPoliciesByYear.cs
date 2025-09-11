using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class BonusPoliciesByYear
{
    public int Id { get; set; }

    public int? BonusYr { get; set; }

    public int? Fprid { get; set; }

    public double SumAssumed { get; set; }

    public int? CommenceYear { get; set; }

    public int? ProductId { get; set; }

    public int? ValidYear { get; set; }

    public int? TermOfYear { get; set; }

    public string? Statas { get; set; }

    public string? StatasEighteen { get; set; }

    public double BonusAmt { get; set; }

    public string? PrevStatas { get; set; }
}
