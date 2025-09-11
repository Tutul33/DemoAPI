using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class WebPaymentHistry
{
    public decimal Sl { get; set; }

    public string? TransectionId { get; set; }

    public string? ApplicantId { get; set; }

    public string? FprId { get; set; }

    public string? OrNumber { get; set; }

    public string? InstallmentNumber { get; set; }

    public double? PremiumAmount { get; set; }

    public string? UserId { get; set; }

    public double? Deposit { get; set; }

    public double? DuePremium { get; set; }

    public double? LateFees { get; set; }

    public int? NoOfLateFees { get; set; }

    public DateOnly? PremDueDate { get; set; }

    public int? NoOfAdjast { get; set; }

    public double? PreviousSuspense { get; set; }

    public string? PaymentMethod { get; set; }

    public string? PaymentPurpose { get; set; }

    public string? BranchName { get; set; }

    public string? CreatedBy { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public string? InstallmentType { get; set; }
}
