using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentFileAllocation
{
    public int Sl { get; set; }

    public int? AgentId { get; set; }

    public string? AgentName { get; set; }

    public int? AssignTo { get; set; }

    public int? Status { get; set; }

    public string? Comments { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? Updatedate { get; set; }
}
