using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentForwardingMaster
{
    public int Id { get; set; }

    public string? AgentName { get; set; }

    public int? AgentId { get; set; }

    public double? TotalAmount { get; set; }

    public int? TotalNoOfPolicy { get; set; }

    public string? StatusFlag { get; set; }

    public string? ForwardingNo { get; set; }

    public string? PaymentMode { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? Comments { get; set; }
}
