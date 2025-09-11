using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class RenewalPercentage
{
    public int Id { get; set; }

    public int PlanId { get; set; }

    public int? TermofYear { get; set; }

    public int? RenewalPercentage1 { get; set; }
}
