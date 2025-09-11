using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class RawtblAgent
{
    public decimal Sl { get; set; }

    public int? AgentId { get; set; }

    public string? PayType { get; set; }

    public int? DuePremium { get; set; }

    public int? DueQty { get; set; }

    public int? TotalPremium { get; set; }

    public int? TotalQty { get; set; }

    public int? LapseAmount { get; set; }

    public int? LapseQty { get; set; }

    public DateTime? DayOfYearVal { get; set; }

    public string? RptType { get; set; }
}
