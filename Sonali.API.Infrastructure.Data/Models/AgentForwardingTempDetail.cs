using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentForwardingTempDetail
{
    public int Id { get; set; }

    public string? RefType { get; set; }

    public int? RefNo { get; set; }

    public string? PolicyHolderName { get; set; }

    public int? Amount { get; set; }

    public string? StatusFlag { get; set; }

    public int? Faid { get; set; }

    public string? Faname { get; set; }

    public int? Umid { get; set; }

    public string? UmName { get; set; }

    public int? Bmid { get; set; }

    public string? Bmname { get; set; }

    public int? PaymentCount { get; set; }

    public string? CreateBy { get; set; }

    public int? TotalAmount { get; set; }

    public string? Comments { get; set; }

    public string? BranchName { get; set; }
}
