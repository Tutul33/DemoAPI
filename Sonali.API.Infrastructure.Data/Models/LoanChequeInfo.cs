using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class LoanChequeInfo
{
    public int Id { get; set; }

    public int? CardAssignId { get; set; }

    public string? DocId { get; set; }

    public string? PolicyHolderName { get; set; }

    public string? BankName { get; set; }

    public string? AcName { get; set; }

    public string? AcNumber { get; set; }

    public double? RecquestAmount { get; set; }

    public string? ApproveStatus { get; set; }

    public string? SliaccountCode { get; set; }

    public string? SliaccountName { get; set; }

    public string? ChequeNo { get; set; }

    public string? ChequeDate { get; set; }

    public string? RoutingNo { get; set; }

    public string? Remarks { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
