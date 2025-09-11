using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AccChart
{
    public decimal Sl { get; set; }

    public decimal? ActCode { get; set; }

    public string? ActName { get; set; }

    public decimal? AccLevel { get; set; }

    public decimal Cl { get; set; }

    public string Inserted { get; set; } = null!;

    public string? IsGroup { get; set; }

    public string Brokerage { get; set; } = null!;

    public string? Ex { get; set; }

    public string UserId { get; set; } = null!;

    public DateTime CreateDate { get; set; }
}
