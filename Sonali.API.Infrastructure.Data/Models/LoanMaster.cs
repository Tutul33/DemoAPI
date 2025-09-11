using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class LoanMaster
{
    public int Id { get; set; }

    public string? DocId { get; set; }

    public string? PolicyHolderName { get; set; }

    public string? PolicyHolderPhone { get; set; }

    public double? LoanAmount { get; set; }

    public int? InstalmentPaid { get; set; }

    public int? TotalInstallments { get; set; }

    public double? ServiceChargeAmount { get; set; }

    public double? BondFees { get; set; }

    public double? Atmfees { get; set; }

    public double? CardFees { get; set; }

    public double? Smsfees { get; set; }

    public double? TotalRepayAmount { get; set; }

    public double? LoanInstallmentAmount { get; set; }

    public DateTime? LastLoanPayDate { get; set; }

    public DateTime? NextLoanDueDate { get; set; }

    public double? TotalLoanDueAmount { get; set; }

    public double? TotalLoanPaidAmount { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? Email { get; set; }

    public double? OtherFees { get; set; }

    public double? DiscountAmount { get; set; }

    public double? SuspenseAmount { get; set; }
}
