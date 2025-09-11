using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AccBankPayForwarding
{
    public decimal Id { get; set; }

    public string? SliBankName { get; set; }

    public string? SliaccNo { get; set; }

    public string? EmailVoucherNo { get; set; }

    public string? BatchNo { get; set; }

    public string? BeneficiaryName { get; set; }

    public string? CustomerAccNo { get; set; }

    public string? TxnTyp { get; set; }

    public string? BankName { get; set; }

    public string? RoutingNo { get; set; }

    public decimal? PayAmount { get; set; }

    public string? Remarks { get; set; }

    public string? Status { get; set; }

    public string? ClaimType { get; set; }

    public string? ClaimId { get; set; }

    public DateOnly? PayDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? DisburseDate { get; set; }

    public string? BankBranchName { get; set; }

    public string? ChequeNo { get; set; }

    public DateTime? ChequeDate { get; set; }
}
