using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class GroupAgentComPayment
{
    public int GrpComId { get; set; }

    public int? Gtliid { get; set; }

    public int? AgentId { get; set; }

    public double? Rate { get; set; }

    public double? BasicCom { get; set; }

    public double? Vat { get; set; }

    public double? TotalCom { get; set; }

    public DateOnly? ComDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
