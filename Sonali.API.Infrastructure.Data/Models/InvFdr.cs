using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class InvFdr
{
    public int Sl { get; set; }

    public int? BankId { get; set; }

    public int? Fdrno { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? MaturityDate { get; set; }

    public string? InterestFrequency { get; set; }

    public decimal? InterestRate { get; set; }

    public decimal? Fdramount { get; set; }

    public decimal? InterestAmount { get; set; }

    public decimal? InterestEarned { get; set; }

    public DateOnly? NextInterestDueDate { get; set; }

    public int? Status { get; set; }

    public string? Source { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public DateOnly? EncashedDate { get; set; }

    public DateOnly? RenewDate { get; set; }
}
