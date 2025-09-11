using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PolicyStatusCheck
{
    public int Id { get; set; }

    public int? PolicyId { get; set; }

    public int? FiscYear { get; set; }

    public string? Status { get; set; }
}
