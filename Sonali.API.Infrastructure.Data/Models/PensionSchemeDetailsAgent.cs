using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PensionSchemeDetailsAgent
{
    public int Sl { get; set; }

    public int? MasterId { get; set; }

    public long? AgentId { get; set; }

    public string? AgentType { get; set; }

    public long? OrentryId { get; set; }

    public long? Fprid { get; set; }

    public int? Installmentno { get; set; }

    public int? Nthyear { get; set; }

    public double? BasicComAmt { get; set; }

    public double? SupComAmt { get; set; }

    public double? VatAmt { get; set; }

    public double? TotalPaymentAmt { get; set; }

    public double? Pfamt { get; set; }

    public DateOnly? Pfdate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
