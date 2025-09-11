using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TestAgentperfad
{
    public decimal Id { get; set; }

    public string? Agent { get; set; }

    public string? Branch { get; set; }

    public string? AgentTypeName { get; set; }

    public string? Samd { get; set; }

    public string? NoOfPr { get; set; }

    public double? SumAssured { get; set; }

    public double? PremiumAmount { get; set; }

    public string? DepositDate { get; set; }

    public string? CommencementDate { get; set; }

    public string? ApplicantName { get; set; }

    public string? MobileNo { get; set; }

    public string? NextPremiumDueDate { get; set; }

    public string? TableAndTerm { get; set; }

    public int? InstallmentNo { get; set; }

    public string? Faumbm { get; set; }
}
