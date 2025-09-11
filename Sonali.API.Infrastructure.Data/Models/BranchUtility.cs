using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class BranchUtility
{
    public int Sl { get; set; }

    public int? BranchId { get; set; }

    public int? MonthCount { get; set; }

    public string? MonthName { get; set; }

    public int? Year { get; set; }

    public string? UtilityType { get; set; }

    public double BillAmount { get; set; }

    public string? Memo { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public string? Comments { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
