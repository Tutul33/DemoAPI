using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class BonusRate
{
    public int Sl { get; set; }

    public int? ProductId { get; set; }

    public int? TermOfYear { get; set; }

    public double? BonusRate1 { get; set; }

    public int? Status { get; set; }

    public int? RelationId { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
