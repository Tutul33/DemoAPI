using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class LoanTransactionDetail
{
    public int Id { get; set; }

    public string? CardUniqueNo { get; set; }

    public string? DocId { get; set; }

    public double? LoanDisburseAmount { get; set; }

    public string? TransactionId { get; set; }

    public string? BankTx { get; set; }

    public DateTime? LoanDisburseDate { get; set; }

    public int? LoanId { get; set; }

    public string? CompanyName { get; set; }

    public string? DisburseStatus { get; set; }

    public string? Sliaccount { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
