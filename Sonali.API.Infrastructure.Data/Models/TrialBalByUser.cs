using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TrialBalByUser
{
    public int Id { get; set; }

    public int? Yr { get; set; }

    public string? ActCode { get; set; }

    public string? ActName { get; set; }

    public decimal? OpBal { get; set; }

    public decimal? Damt { get; set; }

    public decimal? Camt { get; set; }

    public string? Sd { get; set; }

    public string? Ed { get; set; }

    public decimal? FinalBal { get; set; }

    public string? ActTest { get; set; }
}
