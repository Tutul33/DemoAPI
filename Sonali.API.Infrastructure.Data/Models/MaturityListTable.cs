using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class MaturityListTable
{
    public int Sl { get; set; }

    public int? ProductId { get; set; }

    public int? Fprid { get; set; }

    public DateOnly? CommencementDate { get; set; }

    public int? TermOfYear { get; set; }

    public double? TotalPolicyAmount { get; set; }

    public double? Ysapa { get; set; }

    public double? MaturityPaymentAmount { get; set; }

    public double BonusAmount { get; set; }

    public double TotalMaturityPaymentAmount { get; set; }

    public DateOnly? MaturityDate { get; set; }

    public int? Myr { get; set; }

    public string? Mmonths { get; set; }

    public int? MmVal { get; set; }

    public int InsNo { get; set; }

    public int PayStatus { get; set; }

    public int IsPaid { get; set; }

    public DateOnly? MaturityDeliveryDate { get; set; }

    public int? Flag { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateOnly? ApprovalDate { get; set; }

    public decimal? PremiumDeposited { get; set; }

    public decimal? TaxableAmt { get; set; }

    public decimal? Profit { get; set; }

    public decimal? Tax { get; set; }

    public int? Checked { get; set; }

    public string? Comments { get; set; }

    public string? AwaitingComment { get; set; }

    public bool? IsPreAuditDone { get; set; }

    public bool? IsPostAuditDone { get; set; }

    public int? AwaitingDeptId { get; set; }

    public bool? IsSentToPreAudit { get; set; }

    public string? PreAuditSentBy { get; set; }

    public DateTime? PreAuditSentDate { get; set; }

    public string? PreAuditDoneBy { get; set; }

    public DateTime? PreAuditDoneDate { get; set; }

    public string? PostAuditDoneBy { get; set; }

    public DateTime? PostAuditDoneDate { get; set; }
}
