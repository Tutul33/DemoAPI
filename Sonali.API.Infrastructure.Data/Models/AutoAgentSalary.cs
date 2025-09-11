using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AutoAgentSalary
{
    public int Id { get; set; }

    public int? AgentId { get; set; }

    public string? AgentName { get; set; }

    public string? BankName { get; set; }

    public string? BankAcNo { get; set; }

    public string? Organization { get; set; }

    public string? Designation { get; set; }

    public int? TotalPr { get; set; }

    public double? TotalBusiness { get; set; }

    public int? TotalFdr { get; set; }

    public double? Fdramount { get; set; }

    public int? Prod23Pol { get; set; }

    public double? Prod23Amount { get; set; }

    public double? TotalPremium { get; set; }

    public double? Commission { get; set; }

    public string? JobDuration { get; set; }

    public double? Lapse { get; set; }

    public double? Allowance { get; set; }

    public double? Pf { get; set; }

    public double? ExtraIncentive { get; set; }

    public double? OroneYr { get; set; }

    public double? DueOroneYr { get; set; }

    public double? RenOneYr { get; set; }

    public double? DueRenOneYr { get; set; }

    public double? LapseOroneYr { get; set; }

    public double? LapseRenOneYr { get; set; }

    public double? OrtwoYr { get; set; }

    public double? DueOrtwoYr { get; set; }

    public double? RenTwoYr { get; set; }

    public double? DueRenTwoYr { get; set; }

    public double? LapseOrtwoYr { get; set; }

    public double? LapseRenTwoYr { get; set; }

    public double? DeferredPercentOneYr { get; set; }

    public double? RenewalPercentOneYr { get; set; }

    public double? DeferredPercentTwoYr { get; set; }

    public double? RenewalPercentTwoYr { get; set; }

    public int? Samdid { get; set; }

    public string? Samdname { get; set; }

    public string? AgentGroup { get; set; }

    public int? SalMonth { get; set; }

    public int? SalYear { get; set; }

    public string? ReportType { get; set; }

    public string? UserName { get; set; }

    public DateTime? CreateDate { get; set; }

    public double? SalAddition { get; set; }

    public double? SalDeduction { get; set; }

    public int? SalStatus { get; set; }

    public DateTime? PaidDate { get; set; }

    public int Tds { get; set; }
}
