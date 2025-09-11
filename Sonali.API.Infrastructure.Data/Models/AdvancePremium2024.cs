using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AdvancePremium2024
{
    public int Id { get; set; }

    public string? PaymentMode { get; set; }

    public string? TxInfo { get; set; }

    public int? Amount { get; set; }

    public string? PayStatus { get; set; }

    public int? RelationId { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
