using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TmpInvalidClaimDatum
{
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

    public string? Reason { get; set; }

    public string? NomineeInfo { get; set; }

    public string? MultiAccountPayment { get; set; }

    public string? MultiAccountInfo { get; set; }

    public string? BankAccountName { get; set; }

    public string? BankAccountNo { get; set; }

    public string? BankName { get; set; }

    public string? BankBranchName { get; set; }

    public string? BankRoutingNo { get; set; }

    public string? PaymentMethod { get; set; }

    public string? PaymentDetail { get; set; }

    public string? PaymentDate { get; set; }

    public string? PolicyNumber { get; set; }

    public string? RiskStartDate { get; set; }

    public string? DateOfBirth { get; set; }
}
