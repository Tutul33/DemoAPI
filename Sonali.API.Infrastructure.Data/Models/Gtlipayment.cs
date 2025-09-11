using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Gtlipayment
{
    public int PrBmNo { get; set; }

    public DateOnly? PrBmDate { get; set; }

    public string? PaymentPurpose { get; set; }

    public string? PaymentMethod { get; set; }

    public string? BankName { get; set; }

    public string? CheckNo { get; set; }

    public DateOnly? CheckDate { get; set; }

    public string? SliclBankAcc { get; set; }

    public int? GtliId { get; set; }

    public int? AgentId { get; set; }

    public int? BranchId { get; set; }

    public string? Comments { get; set; }

    public double? PaymentAmount { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
