using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ActuaryValuation
{
    public int Sl { get; set; }

    public int? Fprid { get; set; }

    public DateTime? CommencementDate { get; set; }

    public DateTime? FirstDComYy { get; set; }

    public double? M { get; set; }

    public DateTime? FprDate { get; set; }

    public int? ProductId { get; set; }

    public string? PlanName { get; set; }

    public int? TermOfYear { get; set; }

    public DateTime? Dob { get; set; }

    public int? Age { get; set; }

    public double? SumAssured { get; set; }

    public string? PayMode { get; set; }

    public double? LifePrem { get; set; }

    public double? SuppPrem { get; set; }

    public double? ExtraPrem { get; set; }

    public double? TotPrem { get; set; }

    public double? LifeAnnualPrem { get; set; }

    public double? SuppAnnualPrem { get; set; }

    public double? ExtraAnnualPrem { get; set; }

    public double? TotAnnualPrem { get; set; }

    public DateTime? LastPayDate { get; set; }

    public int? Installment { get; set; }
}
