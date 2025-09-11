using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class StipendBankDetail
{
    public decimal BankDetailId { get; set; }

    public decimal? FprId { get; set; }

    public decimal? ClaimId { get; set; }

    public string? AcholderName { get; set; }

    public string? Actype { get; set; }

    public string? AccountNumber { get; set; }

    public string? AcbranchName { get; set; }

    public string? NameOfBank { get; set; }

    public string? BankAddress { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }
}
