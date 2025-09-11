using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentComPayment
{
    public int PaymentId { get; set; }

    public int? AgentId { get; set; }

    public string? AgentName { get; set; }

    public string? AgentType { get; set; }

    public int? Prnumber { get; set; }

    public int? PolicyNumber { get; set; }

    public decimal? BasicComAmount { get; set; }

    public decimal? SupComAmount { get; set; }

    public decimal? PaymentAmount { get; set; }

    public decimal? VatAmount { get; set; }

    public decimal? TotalPayment { get; set; }

    public DateTime? PaymentDate { get; set; }

    public int? InstallmentNumber { get; set; }

    public int? PilicyId { get; set; }

    public int? TermOfYear { get; set; }

    public int? YearNumber { get; set; }

    public int? PaymentStatus { get; set; }

    public string? Acc { get; set; }

    public int? Pf { get; set; }
}
