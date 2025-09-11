using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TmpDeath
{
    public int Sl { get; set; }

    public string? ClaimType { get; set; }

    public string? PolicyNo { get; set; }

    public DateOnly? CommencementDate { get; set; }

    public int? ClaimId { get; set; }

    public int? Fprid { get; set; }

    public string? ApplicantName { get; set; }

    public DateOnly? ClaimDate { get; set; }

    public double? ClaimAmount { get; set; }

    public DateOnly? DecisionDate { get; set; }

    public DateOnly? PaidDate { get; set; }

    public string? SettlementDuration { get; set; }

    public string? ClaimStatus { get; set; }

    public int? StatusFlag { get; set; }

    public string? Comment { get; set; }

    public int? MSl { get; set; }

    public DateOnly? ClaimNotificationDate { get; set; }

    public DateOnly? OcfreceivingDate { get; set; }

    public int? NoOfHoliday { get; set; }
}
