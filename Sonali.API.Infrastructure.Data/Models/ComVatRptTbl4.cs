using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ComVatRptTbl4
{
    public int Sl { get; set; }

    public string? Type { get; set; }

    public string? Fprid { get; set; }

    public int? PrNo { get; set; }

    public int? OrEntryId { get; set; }

    public DateOnly? PayDate { get; set; }

    public int? InstallmentNo { get; set; }

    public decimal? SumAssured { get; set; }

    public decimal? TotalPremiumAmount { get; set; }

    public string? FaName { get; set; }

    public string? UmName { get; set; }

    public string? Bmname { get; set; }

    public decimal? FaCom { get; set; }

    public decimal? UmCom { get; set; }

    public decimal? BmCom { get; set; }

    public decimal? TotalCommission { get; set; }

    public decimal? TotalAit { get; set; }

    public int? Samdid { get; set; }

    public string? SamdName { get; set; }

    public int? BranchId { get; set; }

    public int? NthYear { get; set; }

    public decimal? FaAit { get; set; }

    public decimal? UmAit { get; set; }

    public decimal? BmAit { get; set; }

    public string? Npdd { get; set; }
}
