using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentCommissionPr
{
    public int AgentComId { get; set; }

    public int? AgentId { get; set; }

    public string? AgentTypeName { get; set; }

    public int? ApplicantId { get; set; }

    public int? Prnumber { get; set; }

    public double? BasicComAmount { get; set; }

    public double? SupComAmount { get; set; }

    public double? VatAmout { get; set; }

    public DateOnly? ComDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
