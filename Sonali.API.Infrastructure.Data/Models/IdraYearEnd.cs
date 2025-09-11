using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class IdraYearEnd
{
    public decimal Id { get; set; }

    public string? Typ { get; set; }

    public string? Year { get; set; }

    public string? Df { get; set; }

    public string? Dt { get; set; }
}
