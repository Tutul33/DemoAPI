using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ComPayTmp
{
    public int Sl { get; set; }

    public string? Policyid { get; set; }

    public string? Prid { get; set; }

    public string? Userid { get; set; }

    public decimal? BasicCom { get; set; }

    public decimal? SupCom { get; set; }

    public decimal? Ait { get; set; }

    public string? PaymentMethod { get; set; }

    public string? BankAcc { get; set; }

    public string? AgentType { get; set; }

    public DateTime? Paydt { get; set; }

    public string? Agentid { get; set; }

    public int? Pf { get; set; }
}
