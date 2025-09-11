using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ClaimMasterStatus
{
    public int Sl { get; set; }

    public int Flag { get; set; }

    public string? Status { get; set; }
}
