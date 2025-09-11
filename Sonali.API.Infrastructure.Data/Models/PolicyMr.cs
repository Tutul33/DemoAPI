using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PolicyMr
{
    public int MrId { get; set; }

    public string? PaidBy { get; set; }

    public string? BranchId { get; set; }

    public double DepositAmount { get; set; }

    public DateOnly? DepositDate { get; set; }

    public string? Comments { get; set; }

    public string? PaymentPurpose { get; set; }

    public string? PaymentMethod { get; set; }

    public string? BankName { get; set; }

    public string? CheckNo { get; set; }

    public DateOnly? CheckDate { get; set; }

    public string? SliclBankAcc { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? Fprid { get; set; }

    public int? AgentId { get; set; }
}
