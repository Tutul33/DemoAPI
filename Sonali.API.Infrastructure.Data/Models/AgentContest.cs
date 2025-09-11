using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentContest
{
    public int Sl { get; set; }

    public int? AgentId { get; set; }

    public string? AgentName { get; set; }

    public string? BankName { get; set; }

    public string? BankAcNo { get; set; }

    public string? Branch { get; set; }

    public string? AgentType { get; set; }

    public int? TotalPr { get; set; }

    public double? TotalBusiness { get; set; }

    public double? Incentive { get; set; }

    public string? JobDuration { get; set; }

    public double? BusinessOneYr { get; set; }

    public int? DueOroneYr { get; set; }

    public double? DueAmountOneYr { get; set; }

    public int? LapseOneYr { get; set; }

    public double? LapseAmountOneYr { get; set; }

    public double? BusinessTwoYr { get; set; }

    public int? DueOrtwoYr { get; set; }

    public double? DueAmountTwoYr { get; set; }

    public int? LapseTwoYr { get; set; }

    public double? LapseAmountTwoYr { get; set; }

    public double? DeferredPercentOneYr { get; set; }

    public double? DeferredPercentTwoYr { get; set; }

    public double? RenewalPercentOneYr { get; set; }

    public double? RenewalPercentTwoYr { get; set; }

    public int? Samdid { get; set; }

    public string? Samdname { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public int? ContestMnt { get; set; }

    public int? ContestYr { get; set; }
}
