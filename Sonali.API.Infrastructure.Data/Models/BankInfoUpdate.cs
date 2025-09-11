using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class BankInfoUpdate
{
    public int Sl { get; set; }

    public int? AgentId { get; set; }

    public string? BankName { get; set; }

    public string? BankBranch { get; set; }

    public string? BankAcNo { get; set; }

    public int? AssignTo { get; set; }

    public int? Status { get; set; }

    public string? Comments { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? AssignDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? RoutingNumber { get; set; }
}
