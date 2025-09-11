using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class SbclaimPaid2022
{
    public int Sl { get; set; }

    public int? Fprid { get; set; }

    public double? MaturityAmount { get; set; }

    public DateOnly? PaidDate { get; set; }

    public int? InsNo { get; set; }
}
