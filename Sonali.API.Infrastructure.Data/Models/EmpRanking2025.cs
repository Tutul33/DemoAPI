using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class EmpRanking2025
{
    public int RankId { get; set; }

    public int? EmpId { get; set; }

    public double? TaskAvg { get; set; }

    public double? AttAvg { get; set; }

    public double? BisAvg { get; set; }

    public double? Erpavg { get; set; }

    public double? Average { get; set; }

    public int? Ranking { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }
}
