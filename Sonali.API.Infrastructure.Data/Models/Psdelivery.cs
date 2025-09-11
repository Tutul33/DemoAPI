using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Psdelivery
{
    public int PsdelId { get; set; }

    public DateOnly? RequestDateFrom { get; set; }

    public DateOnly? RequestDateTo { get; set; }

    public double? Psamount { get; set; }

    public int? NoOfPolicies { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }
}
