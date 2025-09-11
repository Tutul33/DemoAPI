using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class SurrenderAnalytic
{
    public int Id { get; set; }

    public int Year { get; set; }

    public byte MonthNo { get; set; }

    public string MonthName { get; set; } = null!;

    public int? PolicyId { get; set; }

    public string? Products { get; set; }

    public string? ClaimStatus { get; set; }

    public double? CalculatedClaimAmount { get; set; }

    public string? Branch { get; set; }

    public int? Fa { get; set; }

    public string? Um { get; set; }

    public string? Bm { get; set; }

    public string? Amd { get; set; }

    public string? Sgm { get; set; }

    public string? Samd { get; set; }
}
