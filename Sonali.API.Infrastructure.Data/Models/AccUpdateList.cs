using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AccUpdateList
{
    public decimal Sl { get; set; }

    public string? Bid { get; set; }

    public string? Bname { get; set; }

    public string? Dbname { get; set; }

    public string? IdCol { get; set; }

    public string? NameCol { get; set; }

    public string? Blevel { get; set; }

    public string? OrigNameCol { get; set; }
}
