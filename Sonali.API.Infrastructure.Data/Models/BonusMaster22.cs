using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class BonusMaster22
{
    public int Sl { get; set; }

    public int? Fprid { get; set; }

    public int? ProductId { get; set; }

    public double? SumAssured { get; set; }

    public int? TermOfYear { get; set; }

    public int? NthYr { get; set; }

    public int? UpdatedYr { get; set; }

    public double? CummulativeBonusAmt { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
