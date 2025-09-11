using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentSalary
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

    public double? TotalPremium { get; set; }

    public double? Commission { get; set; }

    public string? JobDuration { get; set; }

    public double? Lapse { get; set; }

    public double? Allowance { get; set; }

    public double? Pf { get; set; }

    public int? Samdid { get; set; }

    public string? Samdname { get; set; }

    public string? AgentGroup { get; set; }

    public int? SalMonth { get; set; }

    public int? SalYear { get; set; }

    public string? ReportType { get; set; }

    public string? UserName { get; set; }

    public DateTime? CreateDate { get; set; }
}
