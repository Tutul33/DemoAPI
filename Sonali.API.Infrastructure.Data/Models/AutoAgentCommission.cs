using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AutoAgentCommission
{
    public int Id { get; set; }

    public int? AgentId { get; set; }

    public string? AgentName { get; set; }

    public string? BankName { get; set; }

    public string? BankAcNo { get; set; }

    public string? Organization { get; set; }

    public string? Designation { get; set; }

    public string? JobDuration { get; set; }

    public double? Commission { get; set; }

    public double? Ait { get; set; }

    public double? Pf { get; set; }

    public int? Samdid { get; set; }

    public string? Samdname { get; set; }

    public string? AgentGroup { get; set; }

    public int? ComMonth { get; set; }

    public int? ComYear { get; set; }

    public string? ReportType { get; set; }

    public string? UserName { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? ComStatus { get; set; }

    public DateTime? PaidDate { get; set; }

    public int TotalBusiness { get; set; }
}
