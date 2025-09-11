using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PrDetail
{
    public int Sl { get; set; }

    public int? PrBmNo { get; set; }

    public DateOnly? PrBmDate { get; set; }

    public int? ApplicantId { get; set; }

    public int FaId { get; set; }

    public int SamdId { get; set; }

    public int BranchId { get; set; }

    public int InsTypeId { get; set; }

    public double? SumAssured { get; set; }

    public double? TotalPremiumAmount { get; set; }

    public double? TotalCommission { get; set; }

    public double? TotalAit { get; set; }

    public double? TotalEarning { get; set; }

    public double? TotalNetRetention { get; set; }

    public int Umid { get; set; }

    public int Bmid { get; set; }

    public int Bcid { get; set; }

    public int Dcid { get; set; }

    public int Rcid { get; set; }

    public int Dvcid { get; set; }

    public int Sgmid { get; set; }

    public int Amdid { get; set; }
}
