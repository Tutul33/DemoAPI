using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Gtlipercent
{
    public int Id { get; set; }

    public int? Years { get; set; }

    public int? MonthNo { get; set; }

    public string? Months { get; set; }

    public int? NoNoti { get; set; }

    public int? NoOcf { get; set; }

    public decimal? PremRec { get; set; }

    public int? NoOfPol { get; set; }

    public int? NoClaimApproved { get; set; }

    public int? NoClaimPaid { get; set; }

    public decimal? TotClaimPaid { get; set; }

    public int? NoDeclined { get; set; }
}
