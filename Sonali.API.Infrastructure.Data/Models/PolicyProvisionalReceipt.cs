using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PolicyProvisionalReceipt
{
    public int PrBmNo { get; set; }

    public string? PrBmNoChar { get; set; }

    public DateOnly? PrBmDate { get; set; }

    public string? PaymentMethod { get; set; }

    public string? PaymentPurpose { get; set; }

    public int? ApplicantId { get; set; }

    public int? AgentId { get; set; }

    public int? Fprid { get; set; }

    public int BranchCode { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Flag { get; set; }

    public virtual AgentBasicInfo? Agent { get; set; }

    public virtual PolicyApplicantsPersonalInfo? Applicant { get; set; }
}
