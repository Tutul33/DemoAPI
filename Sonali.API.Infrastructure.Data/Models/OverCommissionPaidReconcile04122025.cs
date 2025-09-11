using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class OverCommissionPaidReconcile04122025
{
    public int? AgentId { get; set; }

    public decimal? AchievedCom { get; set; }

    public decimal? PaidCom { get; set; }

    public decimal? OverPaid { get; set; }

    public decimal? Payable { get; set; }

    public decimal? NetPayable { get; set; }

    public decimal? NetReceiveable { get; set; }

    public decimal? Redeemed { get; set; }

    public decimal? ReconciliationExtra { get; set; }
}
