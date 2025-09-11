using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ExtraContribution
{
    public int Id { get; set; }

    public int? FprId { get; set; }

    public double? PremiumAmount { get; set; }

    public double? ContributionAmount { get; set; }

    public int? InsNo { get; set; }

    public string? PolicyStatus { get; set; }

    public string? AccVoucher { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
