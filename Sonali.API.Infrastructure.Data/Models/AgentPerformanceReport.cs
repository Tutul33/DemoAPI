using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentPerformanceReport
{
    public int Sl { get; set; }

    public int? AgentId { get; set; }

    public string? AgentName { get; set; }

    public int? UnitOfficeCode { get; set; }

    public string? BranchOfficeCode { get; set; }

    public string? AgentTypeName { get; set; }

    public int? NoOfPr { get; set; }

    public double? SumAssured { get; set; }

    public double? PremiumAmount { get; set; }

    public DateOnly? DepositDate { get; set; }

    public DateOnly? CommencementDate { get; set; }

    public string? ApplicantName { get; set; }

    public string? MobileNo { get; set; }

    public DateOnly? NextPremiumDueDate { get; set; }

    public string? TableAndTerm { get; set; }

    public int? InstallmentNo { get; set; }

    public string? Faid { get; set; }

    public string? Faname { get; set; }

    public string? Umid { get; set; }

    public string? Umname { get; set; }

    public string? Bmid { get; set; }

    public string? Bmname { get; set; }

    public string? Samd { get; set; }

    public string? CreateBy { get; set; }
}
