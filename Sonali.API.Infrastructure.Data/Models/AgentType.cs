using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentType
{
    public int AgentTypeId { get; set; }

    public string? AgentTypeName { get; set; }

    public string? AgentTypeShortFrom { get; set; }

    public string? AgentIdSequence { get; set; }

    public string? RenewReminder { get; set; }

    public int Hierarchy { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? AgentTypeShortFromNew { get; set; }

    public virtual ICollection<AgentJobDetail> AgentJobDetails { get; set; } = new List<AgentJobDetail>();
}
