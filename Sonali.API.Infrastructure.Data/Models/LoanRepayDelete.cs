using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class LoanRepayDelete
{
    public int Id { get; set; }

    public int RepayId { get; set; }

    public int? LoanId { get; set; }

    public DateTime? LoanDueDate { get; set; }

    public int? InstallmentNo { get; set; }

    public double? InstallmentAmount { get; set; }

    public double? ServiceChargeAmount { get; set; }

    public double? BondFees { get; set; }

    public double? Atmfees { get; set; }

    public double? CardFees { get; set; }

    public string? PayStatus { get; set; }

    public double? DepositAmount { get; set; }

    public DateTime? DepositDate { get; set; }

    public double? LateFees { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public double? Smsfees { get; set; }

    public double? OtherFees { get; set; }

    public double? DiscountAmount { get; set; }

    public double? SuspenseAmount { get; set; }

    public string? UserName { get; set; }

    public DateTime? PostingDate { get; set; }
}
