using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ReinsurencePerPolicy
{
    public int PolicyReInsId { get; set; }

    public int? FprId { get; set; }

    public string? DocId { get; set; }

    public double? ReInsBasicAmount { get; set; }

    public double? ReInsSuppAmount { get; set; }

    public double? ReInsBasicPremium { get; set; }

    public double? ReInsSupPremium { get; set; }

    public double? TotalReInsPremium { get; set; }

    public double? BasicRate { get; set; }

    public double? SupRate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
