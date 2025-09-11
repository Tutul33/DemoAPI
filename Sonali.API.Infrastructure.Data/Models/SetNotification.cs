using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class SetNotification
{
    public int Sl { get; set; }

    public int? ApplicantId { get; set; }

    public DateOnly? Prdate { get; set; }

    public double? PremiumAmount { get; set; }

    public DateOnly? MaturityDate { get; set; }

    public double? InterestRate { get; set; }

    public double? InterestAmount { get; set; }

    public string? AccountHolderName { get; set; }

    public string? AccountNo { get; set; }

    public string? BankName { get; set; }

    public string? BankBranch { get; set; }

    public string? NotificationFrequency { get; set; }

    public DateOnly? NotificationDate { get; set; }

    public string? UserToNotify { get; set; }

    public DateOnly? PayDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
