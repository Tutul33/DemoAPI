using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class BranchRentUtility
{
    public int Sl { get; set; }

    public int? BranchId { get; set; }

    public int? MonthCount { get; set; }

    public string? MonthName { get; set; }

    public int? Year { get; set; }

    public double Rent { get; set; }

    public double AdjustedRent { get; set; }

    public double AdvanceRemaining { get; set; }

    public double RentPayment { get; set; }

    public double Electricity { get; set; }

    public double Water { get; set; }

    public double ServiceCharge { get; set; }

    public double Others { get; set; }

    public double TotalUtility { get; set; }

    public string? Memo { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public string? Comments { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
