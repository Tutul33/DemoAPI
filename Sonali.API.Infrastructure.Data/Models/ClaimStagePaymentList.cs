using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ClaimStagePaymentList
{
    public int Sl { get; set; }

    public int? ProductId { get; set; }

    public int? Fprid { get; set; }

    public DateOnly? CommencementDate { get; set; }

    public int? TermOfYear { get; set; }

    public double? TotalPolicyAmount { get; set; }

    public double? Ysapa { get; set; }

    public double? ClaimPaymentAmount { get; set; }

    public double BonusAmount { get; set; }

    public double TotalClaimPaymentAmount { get; set; }

    public DateOnly? ClaimDate { get; set; }

    public int? Cyr { get; set; }

    public string? Cmonths { get; set; }

    public int? CmVal { get; set; }

    public int InsNo { get; set; }

    public int PayStatus { get; set; }

    public int IsPaid { get; set; }

    public DateOnly? ClaimDeliveryDate { get; set; }

    public int? Flag { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateOnly? ApprovalDate { get; set; }
}
