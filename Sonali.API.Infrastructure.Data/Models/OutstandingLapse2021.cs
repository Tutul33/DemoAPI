using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class OutstandingLapse2021
{
    public int? Fprid { get; set; }

    public int OrEntryId { get; set; }

    public double? TotalPremiumAmount { get; set; }

    public DateOnly? OrentryDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
