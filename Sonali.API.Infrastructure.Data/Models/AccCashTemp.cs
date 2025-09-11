using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AccCashTemp
{
    public decimal Id { get; set; }

    public string? FromActCode { get; set; }

    public double? Damount { get; set; }

    public double? Camount { get; set; }
}
