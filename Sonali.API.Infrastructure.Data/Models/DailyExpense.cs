using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class DailyExpense
{
    public int ExpId { get; set; }

    public string? ExpTypeId { get; set; }

    public string? ExpTypeName { get; set; }

    public string? Branch { get; set; }

    public double? Amount { get; set; }

    public DateOnly? ExpDate { get; set; }

    public string? Comments { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? VoucherNo { get; set; }

    public string? Chq { get; set; }

    public string? AgentType { get; set; }

    public string? AgentId { get; set; }
}
