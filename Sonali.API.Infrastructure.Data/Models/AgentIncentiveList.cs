using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentIncentiveList
{
    public int Sl { get; set; }

    public DateOnly? IncentiveDate { get; set; }

    public long? AgentId { get; set; }

    public string? AgentType { get; set; }

    public int? SamdId { get; set; }

    public int? TotalNoOfPr { get; set; }

    public double? TotalSinglePremium { get; set; }

    public double? TotalLifePremium { get; set; }

    public double? TotalPremium { get; set; }

    public double? TotalNetCommissionLife { get; set; }

    public double? Persistency { get; set; }

    public double? IncentiveAmount { get; set; }

    public int? Eligibility { get; set; }

    public string? Createby { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? UpdateDate { get; set; }
}
