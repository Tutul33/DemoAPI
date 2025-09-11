using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AccClosingTbl
{
    public decimal Id { get; set; }

    public string? Actcode { get; set; }

    public string? ActName { get; set; }

    public decimal? Amount { get; set; }

    public string? UserId { get; set; }
}
