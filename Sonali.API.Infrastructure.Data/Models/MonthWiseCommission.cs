using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class MonthWiseCommission
{
    public int Id { get; set; }

    public int AgentComId { get; set; }

    public int? InstallmentNo { get; set; }

    public string? Orstatus { get; set; }

    public string? AgentTypeName { get; set; }

    public double? Comm { get; set; }

    public double? Ait { get; set; }

    public int BillMonth { get; set; }

    public int BillYear { get; set; }

    public string? BillNo { get; set; }

    public DateTime? BillDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime CreateDate { get; set; }
}
