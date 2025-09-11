using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ReinsuranceExtraPremium
{
    public int Id { get; set; }

    public string? DocId { get; set; }

    public int? Fprid { get; set; }

    public double? ExtraBasicPremium { get; set; }

    public double? ExtraSuppPremium { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
