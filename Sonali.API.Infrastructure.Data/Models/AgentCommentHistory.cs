using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentCommentHistory
{
    public int Sl { get; set; }

    public int? AgentId { get; set; }

    public string? Comments { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
