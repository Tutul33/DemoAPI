using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TmpAgentForwardingError
{
    public int? RefNo { get; set; }

    public string? PolicyHolderName { get; set; }

    public string? Mobile { get; set; }

    public double? Amount { get; set; }

    public string Company { get; set; } = null!;

    public string? BankBranch { get; set; }

    public string Status { get; set; } = null!;

    public int? Fprid { get; set; }

    public string? TransectionId { get; set; }

    public string? BankDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? BankName { get; set; }

    public string? Token { get; set; }

    public string? ForwardingNo { get; set; }

    public int? Faid { get; set; }

    public string? Faname { get; set; }

    public int? Umid { get; set; }

    public string? UmName { get; set; }

    public int? Bmid { get; set; }

    public string? Bmname { get; set; }

    public int? PaymentCount { get; set; }

    public int AgentForwardingMasterId { get; set; }

    public int AgentForwardingDetailsId { get; set; }
}
