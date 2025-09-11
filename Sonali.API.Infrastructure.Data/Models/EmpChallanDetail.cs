using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class EmpChallanDetail
{
    public int Id { get; set; }

    public int? EmpId { get; set; }

    public string? SalMonthName { get; set; }

    public int? SalMonthValue { get; set; }

    public int? SalYear { get; set; }

    public string? ChallanNo { get; set; }

    public DateOnly? ChallanDate { get; set; }

    public string? BankName { get; set; }

    public string? BankBranch { get; set; }

    public double? ChallanAmount { get; set; }

    public double? EmpTaxAmount { get; set; }

    public string? Remarks { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
