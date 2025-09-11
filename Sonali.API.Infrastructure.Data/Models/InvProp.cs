using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class InvProp
{
    public decimal Id { get; set; }

    public string? ActCode { get; set; }

    public string? ProjectName { get; set; }

    public DateOnly? StartDate { get; set; }

    public string? Loc { get; set; }

    public decimal? Amt { get; set; }
}
