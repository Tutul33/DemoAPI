using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AccTransTemp
{
    public decimal Sl { get; set; }

    public string? EntryBy { get; set; }

    public string ActCode { get; set; } = null!;

    public string? ActName { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }

    public string? Comments { get; set; }
}
