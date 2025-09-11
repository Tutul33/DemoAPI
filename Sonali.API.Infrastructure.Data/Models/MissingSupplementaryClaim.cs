using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class MissingSupplementaryClaim
{
    public int Sl { get; set; }

    public int? Fprid { get; set; }

    public double? PaidAmount { get; set; }

    public DateOnly? PaidDate { get; set; }
}
