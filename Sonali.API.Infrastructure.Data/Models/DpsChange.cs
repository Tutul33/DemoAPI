using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class DpsChange
{
    public decimal? Id { get; set; }

    public string? NameNew { get; set; }

    public string? NameOld { get; set; }
}
