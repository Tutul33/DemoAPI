using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentForwardingDetail
{
    public int Id { get; set; }

    public int? ForwardingSummaryId { get; set; }

    public string? RefType { get; set; }

    public int? RefNo { get; set; }

    public string? PolicyHolderName { get; set; }

    public double? Amount { get; set; }

    public string? StatusFlag { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? Faid { get; set; }

    public string? Faname { get; set; }

    public int? Umid { get; set; }

    public string? UmName { get; set; }

    public int? Bmid { get; set; }

    public string? Bmname { get; set; }

    public int? PaymentCount { get; set; }

    public double? TotalAmount { get; set; }

    public string? Comments { get; set; }
}
