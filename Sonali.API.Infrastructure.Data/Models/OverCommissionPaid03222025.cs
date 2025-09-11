using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class OverCommissionPaid03222025
{
    public int AgentId { get; set; }

    public string? AgentName { get; set; }

    public string MobileNo { get; set; } = null!;

    public string? BankName { get; set; }

    public string? BankAcNo { get; set; }

    public string? Organization { get; set; }

    public string? Designation { get; set; }

    public string? ReportType { get; set; }

    public double OldCommission { get; set; }

    public double NewCommission { get; set; }

    public double OverCommissionPaid { get; set; }

    public double? AdjustedAmt { get; set; }

    public double? RemainingAmt { get; set; }

    public double? AdjustedAmtApr { get; set; }

    public double? RemainingAmtApr { get; set; }

    public double? AdjustedAmtMay { get; set; }

    public double? RemainingAmtMay { get; set; }

    public int? Bkp { get; set; }
}
