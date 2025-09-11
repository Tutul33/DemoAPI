using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PolicyInstallmentType
{
    public int InstallmentTypeId { get; set; }

    public string? InstallmentTypeName { get; set; }

    public int? Value { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? MonthValue { get; set; }

    public virtual ICollection<PolicyApplicantsPolicyInfo> PolicyApplicantsPolicyInfos { get; set; } = new List<PolicyApplicantsPolicyInfo>();
}
