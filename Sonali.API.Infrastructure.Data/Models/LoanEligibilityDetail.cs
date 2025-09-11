using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class LoanEligibilityDetail
{
    public int Id { get; set; }

    public string? DocId { get; set; }

    public int? FprId { get; set; }

    public int? PlanId { get; set; }

    public int? TermofYear { get; set; }

    public DateTime? CommencementDate { get; set; }

    public DateTime? NextLoanDueDate { get; set; }

    public int? MonthValue { get; set; }

    public DateTime? MaturityDate { get; set; }

    public double? SurrenderValueAmount { get; set; }

    public string? InstallmentType { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
