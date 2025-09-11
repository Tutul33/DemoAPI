using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PolicyInfo
{
    public int PolicyId { get; set; }

    public string? PolicyName { get; set; }

    public string? PolicyNameBangla { get; set; }

    public int? PolicyCategory { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? Category { get; set; }

    public string? CategoryBangla { get; set; }

    public string? ImgName { get; set; }

    public int? AllowableExpPer { get; set; }

    public virtual ICollection<PolicyApplicantsPolicyInfo> PolicyApplicantsPolicyInfos { get; set; } = new List<PolicyApplicantsPolicyInfo>();

    public virtual ICollection<PolicyFpr> PolicyFprs { get; set; } = new List<PolicyFpr>();

    public virtual ICollection<PolicyInsurancePlan> PolicyInsurancePlans { get; set; } = new List<PolicyInsurancePlan>();

    public virtual ICollection<TmpPolicyApplicantsPolicyInfo> TmpPolicyApplicantsPolicyInfos { get; set; } = new List<TmpPolicyApplicantsPolicyInfo>();
}
