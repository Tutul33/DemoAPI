using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentBusinessTwoYr
{
    public int Sl { get; set; }

    public int? AgentId { get; set; }

    public string? AgentName { get; set; }

    public string? BankName { get; set; }

    public string? BankAcNo { get; set; }

    public string? Organization { get; set; }

    public string? Designation { get; set; }

    public int? TotalPr { get; set; }

    public double? TotalBusiness { get; set; }

    public string? JobDuration { get; set; }

    public string? AgentGroup { get; set; }

    public int? NoOfDues { get; set; }

    public double? DueAmount { get; set; }

    public int? NoOfLapse { get; set; }

    public double? LapseAmount { get; set; }

    public double? BusinessPercentage { get; set; }

    public int? Samdid { get; set; }

    public string? Samdname { get; set; }

    public string? Orstatus { get; set; }

    public int? Qtr { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public int? BusinessYr { get; set; }

    public DateTime? PostedOn { get; set; }
}
