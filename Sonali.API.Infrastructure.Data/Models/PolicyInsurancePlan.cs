using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PolicyInsurancePlan
{
    public int InsurncePlanId { get; set; }

    public int? PolicyId { get; set; }

    public string? Age { get; set; }

    public int? TermOfYear { get; set; }

    public double? Rate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual PolicyInfo? Policy { get; set; }

    public virtual ICollection<PolicyFpr> PolicyFprs { get; set; } = new List<PolicyFpr>();
}
