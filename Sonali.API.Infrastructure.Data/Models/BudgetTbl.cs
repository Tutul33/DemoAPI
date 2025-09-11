using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class BudgetTbl
{
    public decimal Sl { get; set; }

    public string? ActCode { get; set; }

    public int? Mon { get; set; }

    public int? CurYr { get; set; }

    public decimal? CurYrAmt { get; set; }

    public int? PrevYr { get; set; }

    public decimal? PrevYrAmt { get; set; }

    public int? PrevYrLess { get; set; }

    public decimal? PrevYrLessAmt { get; set; }

    public decimal? Avrg { get; set; }

    public decimal? Median { get; set; }

    public decimal? ForecastAmt { get; set; }

    public decimal? Change { get; set; }

    public string? ActName { get; set; }
}
