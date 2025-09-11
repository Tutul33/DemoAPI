using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentPerfTemp2RenewalCurrent
{
    public int Sl { get; set; }

    public int? MainSl { get; set; }

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

    public int? Bcid { get; set; }

    public int? Dcid { get; set; }

    public int? Rcid { get; set; }

    public int? Dvcid { get; set; }

    public int? Sgmid { get; set; }

    public int? Amdid { get; set; }

    public int? SamdId { get; set; }

    public string? SamdName { get; set; }

    public string? Typ { get; set; }

    public DateTime CreateDt { get; set; }

    public decimal? PrNo { get; set; }

    public decimal? OrId { get; set; }
}
