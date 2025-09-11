using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Gtlialteration
{
    public int GtliAlterationId { get; set; }

    public int? OldTotalNoEmp { get; set; }

    public double? OldTotSumAtRisk { get; set; }

    public double? OldBasicPremium { get; set; }

    public double? OldSuppPremium { get; set; }

    public double? OldExtraPremium { get; set; }

    public double? OldTotalPremium { get; set; }

    public int? GtliId { get; set; }

    public int? TotalNumberofAltEmp { get; set; }

    public double? AlteredAmount { get; set; }

    public string? OldGtliSupplementaryId { get; set; }

    public int? AlterFlag { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
