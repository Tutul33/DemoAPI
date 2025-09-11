using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class WebProduct
{
    public int Serial { get; set; }

    public int? PolicyId { get; set; }

    public string? TermOfThePolicy { get; set; }

    public string? TermOfThePolicyBangla { get; set; }

    public string? SupplementaryCover { get; set; }

    public string? OnMaturity { get; set; }

    public string? OnMaturityBangla { get; set; }

    public string? InCaseOfAssuredDeath { get; set; }

    public string? InCaseOfAssuredDeathBangla { get; set; }

    public string? SpecialBenefit { get; set; }

    public string? SpecialBenefitBangla { get; set; }

    public string? ChartRate { get; set; }

    public string? CreateBy { get; set; }

    public string? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public string? UpdateDate { get; set; }

    public string? YouTubeLink { get; set; }

    public string? SupplementaryCoverBangla { get; set; }
}
