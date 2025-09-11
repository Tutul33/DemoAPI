using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PolicySupplementry
{
    public int SupplimentryPolicyId { get; set; }

    public int? SupplimentryId { get; set; }

    public string? Class { get; set; }

    public double? Rate { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public int? TermOfYear { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
