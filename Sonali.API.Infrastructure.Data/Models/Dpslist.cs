using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Dpslist
{
    public int Id { get; set; }

    public string? DpsNo { get; set; }

    public string? BankId { get; set; }

    public string? BankName { get; set; }

    public string? AccNo { get; set; }

    public string? DepoFreq { get; set; }

    public double? InstallmentAmt { get; set; }

    public double? DpsAmt { get; set; }

    public double? MaturityAmt { get; set; }

    public string? ActiveStatus { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? MaturityDate { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public double? DepositedAmt { get; set; }
}
