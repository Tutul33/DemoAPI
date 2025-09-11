using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AccBankCheque
{
    public decimal Id { get; set; }

    public string? AccNo { get; set; }

    public string? BookNo { get; set; }

    public string? ChequeNo { get; set; }

    public string? ChequeStatus { get; set; }

    public string? VoucherNo { get; set; }

    public DateOnly? ChequeDate { get; set; }

    public string? Notes { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
