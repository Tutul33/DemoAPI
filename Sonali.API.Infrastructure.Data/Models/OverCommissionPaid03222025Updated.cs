using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class OverCommissionPaid03222025Updated
{
    public int? AgentId { get; set; }

    public string? AgentName { get; set; }

    public string MobileNo { get; set; } = null!;

    public string? BankName { get; set; }

    public string? BankAcNo { get; set; }

    public string? Organization { get; set; }

    public string? Designation { get; set; }

    public string? ReportType { get; set; }

    public double OldCommission { get; set; }

    public double NewCommission { get; set; }

    public double? NewComV2 { get; set; }

    public double? PayableAmtV2 { get; set; }

    public double OverCommissionPaid { get; set; }

    public string? AdjustedStatus { get; set; }

    public double? RemainingAmt { get; set; }
}
