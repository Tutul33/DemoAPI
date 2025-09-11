using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ExecutiveList
{
    public int Id { get; set; }

    public int AgentId { get; set; }

    public int? EmpId { get; set; }

    public string EmpName { get; set; } = null!;

    public string EmpDesignation { get; set; } = null!;

    public string? AgentType { get; set; }

    public DateTime CreateDate { get; set; }
}
