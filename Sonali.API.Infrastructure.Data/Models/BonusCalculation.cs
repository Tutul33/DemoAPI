using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class BonusCalculation
{
    public decimal BonusCalcId { get; set; }

    public decimal? RevDetailId { get; set; }

    public int? ClaimId { get; set; }

    public int? PolicyId { get; set; }

    public int? BonusYear { get; set; }

    public decimal? BonusAmount { get; set; }

    public string? BonusStatus { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }
}
