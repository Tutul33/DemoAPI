using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PolicySupplimentryEntry
{
    public int SupplimentryId { get; set; }

    public string? SubPolicyName { get; set; }

    public decimal? SubPolicyValue { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<PolicyFpr> PolicyFprs { get; set; } = new List<PolicyFpr>();

    public virtual ICollection<TmpPolicyApplicantsPolicyInfo> TmpPolicyApplicantsPolicyInfos { get; set; } = new List<TmpPolicyApplicantsPolicyInfo>();
}
