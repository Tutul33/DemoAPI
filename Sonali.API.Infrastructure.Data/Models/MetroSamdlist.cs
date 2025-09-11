using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class MetroSamdlist
{
    public int Id { get; set; }

    public int? AgentId { get; set; }

    public string? AgentName { get; set; }
}
