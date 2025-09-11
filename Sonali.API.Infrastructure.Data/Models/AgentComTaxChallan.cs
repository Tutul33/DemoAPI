using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentComTaxChallan
{
    public int Id { get; set; }

    public string? AgentType { get; set; }

    public int? MonthId { get; set; }

    public string? Month { get; set; }

    public int? Year { get; set; }

    public string? ChallanNo { get; set; }

    public DateOnly? ChallanDt { get; set; }

    public string? BankId { get; set; }

    public string? BankName { get; set; }

    public string? BranchName { get; set; }

    public decimal? TotalAmtInChallan { get; set; }

    public string? Remarks { get; set; }

    public string? CreateBy { get; set; }

    public DateTime CreateDt { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDt { get; set; }
}
