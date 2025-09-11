using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class InvBondBuy
{
    public int Sl { get; set; }

    public int? NameId { get; set; }

    public string? ActCode { get; set; }

    public double? BuyAmount { get; set; }

    public double? InterestRate { get; set; }

    public string? InterestFrequency { get; set; }

    public double? InterestEarned { get; set; }

    public DateOnly? MaturityDate { get; set; }

    public DateOnly? BuyDate { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public string Statas { get; set; } = null!;
}
