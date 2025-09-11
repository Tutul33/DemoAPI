using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentPersonalLapse
{
    public int Id { get; set; }

    public int? AgentId { get; set; }

    public string? AgentType { get; set; }

    public int? FprId { get; set; }

    public DateOnly? LapseDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
