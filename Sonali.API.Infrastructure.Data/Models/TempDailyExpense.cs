using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TempDailyExpense
{
    public int Sl { get; set; }

    public string? Branch { get; set; }

    public string? ExpenseType { get; set; }

    public string? ExpenseTypeId { get; set; }

    public string? ExpenseDate { get; set; }

    public double? Amount { get; set; }

    public string? PayType { get; set; }

    public string? BankAc { get; set; }

    public string? ChequeNo { get; set; }

    public string? Comments { get; set; }

    public string? VoucherNo { get; set; }

    public string? BankCash { get; set; }

    public double? AdvRent { get; set; }

    public string? AdvRentAcc { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? AgentType { get; set; }

    public string? AgentId { get; set; }

    public string? ChequeId { get; set; }
}
