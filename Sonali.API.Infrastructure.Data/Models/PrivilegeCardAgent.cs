using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PrivilegeCardAgent
{
    public int Id { get; set; }

    public int? AgentId { get; set; }

    public string? CardType { get; set; }

    public string? AccNo { get; set; }

    public string? BankName { get; set; }

    public string? BankBranch { get; set; }

    public DateOnly? CardIssueDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
