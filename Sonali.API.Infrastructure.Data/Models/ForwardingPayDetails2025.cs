using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ForwardingPayDetails2025
{
    public int Id { get; set; }

    public int? ForwardingId { get; set; }

    public string? PaymentMethod { get; set; }

    public string? AccountCode { get; set; }

    public string? BankName { get; set; }

    public string? RefNo { get; set; }

    public string? ChequeDate { get; set; }

    public string? DocImage { get; set; }

    public double? Amount { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? Year { get; set; }

    public double? Advanced { get; set; }

    public string? Details { get; set; }

    public string? Commence { get; set; }
}
