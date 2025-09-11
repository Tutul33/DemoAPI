using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Tinserted
{
    public int Sl { get; set; }

    public int? OrentryId { get; set; }

    public DateOnly? OrentryDate { get; set; }

    public int? Fprid { get; set; }

    public decimal? ActPrem { get; set; }

    public double? TotalPremiumAmount { get; set; }

    public double? DepositAmount { get; set; }

    public double PrevSuspense { get; set; }

    public double? SuspenseAmount { get; set; }

    public double? LateFees { get; set; }

    public int? NoOfLateFees { get; set; }

    public DateOnly? NextPremiumDueDate { get; set; }

    public DateOnly? LastPremiumDueDate { get; set; }

    public int? InstallmentNo { get; set; }

    public int? PaymentStatus { get; set; }

    public string? PaymentMethod { get; set; }

    public string? PaymentPurpose { get; set; }

    public string? BranchName { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
