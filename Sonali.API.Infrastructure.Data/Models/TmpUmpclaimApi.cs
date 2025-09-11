using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TmpUmpclaimApi
{
    public int FprId { get; set; }

    public byte? Flag { get; set; }

    public DateTime PostingDate { get; set; }

    public DateTime? ResponseDate { get; set; }

    public int? ClaimId { get; set; }

    public byte? Type { get; set; }

    public string? ClaimNo { get; set; }

    public string? ClaimDate { get; set; }

    public string? IntimationNumber { get; set; }

    public string? IntimationDate { get; set; }

    public string? InsuranceType { get; set; }

    public string? ClaimType { get; set; }

    public string? InstallmentNumber { get; set; }

    public string? ClaimAmount { get; set; }

    public string? AccruedBonus { get; set; }

    public string? Suspense { get; set; }

    public string? TotalAmount { get; set; }

    public string? Deduction { get; set; }

    public string? NetPayable { get; set; }

    public string? DeductionCause { get; set; }

    public string? ReinsuranceClaimAmount { get; set; }

    public string? ClaimStatus { get; set; }

    public string? UnsetteledReason { get; set; }

    public string? PolicyNumber { get; set; }

    public string? RiskStartDate { get; set; }

    public string? DateOfBirth { get; set; }
}
