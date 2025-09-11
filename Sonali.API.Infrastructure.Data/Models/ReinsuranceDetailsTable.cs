using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ReinsuranceDetailsTable
{
    public int ReinsuranceDetailId { get; set; }

    public int? Fprid { get; set; }

    public string? DocId { get; set; }

    public int? InstallmentNo { get; set; }

    public double? TotalRiskAmount { get; set; }

    public double? ReInsBasicAmount { get; set; }

    public double? ReInsSuppAmount { get; set; }

    public double? ReInsBasicPremium { get; set; }

    public double? ReInsSuppPremium { get; set; }

    public double? BasicRate { get; set; }

    public double? SuppRate { get; set; }

    public double? ReinsuranceInstallmentAount { get; set; }

    public double? CommissionPercentage { get; set; }

    public double? ActualPayAmount { get; set; }

    public int? PaymentMakeFlag { get; set; }

    public DateOnly? ReicnsPayDate { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
