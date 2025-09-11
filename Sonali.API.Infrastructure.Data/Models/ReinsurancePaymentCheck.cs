using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ReinsurancePaymentCheck
{
    public int ReinsurancePaymentId { get; set; }

    public int? Fprid { get; set; }

    public double? ReinsuranceBasicPremium { get; set; }

    public double? ReinsuranceSupplePremium { get; set; }

    public double? ReinsuranceTotalPremium { get; set; }

    public double? ReinsuranceActualPay { get; set; }

    public int? ReinsurancePayStatus { get; set; }

    public int? NthYear { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
