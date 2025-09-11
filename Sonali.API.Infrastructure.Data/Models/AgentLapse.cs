using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentLapse
{
    public int Id { get; set; }

    public int? Fprid { get; set; }

    public int? InstallmentTypeId { get; set; }

    public double? TotalInstallmentsPaid { get; set; }

    public double? PremiumAmount { get; set; }

    public int? Faid { get; set; }

    public int? Umid { get; set; }

    public int? Bmid { get; set; }

    public int? Bcid { get; set; }

    public int? Dcid { get; set; }

    public int? Rcid { get; set; }

    public int? Dvcid { get; set; }

    public int? Sgmid { get; set; }

    public int? Amdid { get; set; }

    public int? Samdid { get; set; }

    public DateOnly? LapseDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
