using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PolicyHolderTaxChallan
{
    public int Id { get; set; }

    public int? MonthId { get; set; }

    public string? Month { get; set; }

    public int? Year { get; set; }

    public string? ChallanNo { get; set; }

    public DateTime? ChallanDate { get; set; }

    public int? BankId { get; set; }

    public string? BankName { get; set; }

    public string? BranchName { get; set; }

    public double? ChallanAmount { get; set; }

    public string? Remarks { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
