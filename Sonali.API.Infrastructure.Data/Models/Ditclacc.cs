using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Ditclacc
{
    public int Id { get; set; }

    public string? ActCode { get; set; }

    public string? ActName { get; set; }

    public decimal? Damount { get; set; }

    public decimal? Camount { get; set; }

    public string? Df { get; set; }

    public string? Dt { get; set; }

    public string? NewName { get; set; }
}
