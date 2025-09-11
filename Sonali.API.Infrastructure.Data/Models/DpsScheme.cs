using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class DpsScheme
{
    public decimal Sl { get; set; }

    public decimal? BankId { get; set; }

    public string? DpsNo { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? MaturityDate { get; set; }

    public string? SchemeType { get; set; }

    public string? DepoFreq { get; set; }

    public decimal? InstallmentAmt { get; set; }

    public decimal? DpsAmt { get; set; }

    public decimal? MaturityAmt { get; set; }

    public string? ActiveStatus { get; set; }

    public DateOnly? DisableDate { get; set; }

    public string? DisableBy { get; set; }

    public DateTime? DisableDateTime { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public DateTime CreateDateTime { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
