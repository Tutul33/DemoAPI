using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class MarchComAdjustment
{
    public int? AgentId { get; set; }

    public string? PayStatus { get; set; }

    public decimal? AchievedCom { get; set; }

    public double? Paidcommission { get; set; }

    public double? Payable { get; set; }

    public double ActualPayable { get; set; }

    public double ActualReceivable { get; set; }

    public string? Remarks { get; set; }

    public DateTime? AdjustDate { get; set; }
}
