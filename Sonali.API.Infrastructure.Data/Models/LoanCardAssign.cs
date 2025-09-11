using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class LoanCardAssign
{
    public int Id { get; set; }

    public string? DocId { get; set; }

    public string? PolicyHolderName { get; set; }

    public string? PolicyHolderMobile { get; set; }

    public double? TotalSvamount { get; set; }

    public double? TotalLoanAmount { get; set; }

    public double? TotalDueAmount { get; set; }

    public double? TotalPaidAmount { get; set; }

    public string? CardUniqueNo { get; set; }

    public string? DispatchType { get; set; }

    public string? CardNo { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? BankName { get; set; }

    public string? AcName { get; set; }

    public string? AcNumber { get; set; }

    public double? RecquestAmount { get; set; }

    public string? ApproveStatus { get; set; }

    public string? Sliaccount { get; set; }

    public string? TokenId { get; set; }
}
