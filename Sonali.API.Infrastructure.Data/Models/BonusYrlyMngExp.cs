using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class BonusYrlyMngExp
{
    public int Sl { get; set; }

    public int? ProductId { get; set; }

    public int? NthYear { get; set; }

    public double? Rate { get; set; }

    public int? Status { get; set; }

    public int? RelationId { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
