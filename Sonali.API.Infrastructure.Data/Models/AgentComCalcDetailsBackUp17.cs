using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentComCalcDetailsBackUp17
{
    public int AgentComId { get; set; }

    public int? AgentId { get; set; }

    public string? AgentTypeName { get; set; }

    public int? PolicyId { get; set; }

    public string? PolicyNumber { get; set; }

    public int? Prnumber { get; set; }

    public double BasicComAmount { get; set; }

    public double SupComAmount { get; set; }

    public double VatAmout { get; set; }

    public double Ic { get; set; }

    public double Icbalance { get; set; }

    public double Rc { get; set; }

    public int? IsPaid { get; set; }

    public int Forward { get; set; }

    public int? InstallmentNumber { get; set; }

    public int? Fprid { get; set; }

    public string? Acc { get; set; }

    public DateTime? ComDate { get; set; }

    public DateOnly? ForwardDate { get; set; }

    public DateOnly? PayDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
