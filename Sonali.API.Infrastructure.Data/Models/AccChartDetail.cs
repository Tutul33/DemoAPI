using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AccChartDetail
{
    public decimal Id { get; set; }

    public decimal? ActCode { get; set; }

    public string? ActName { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string UserId { get; set; } = null!;
}
