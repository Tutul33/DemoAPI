using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class UmrahTour2023
{
    public int Id { get; set; }

    public int? AgentId { get; set; }

    public string? AgentName { get; set; }

    public string? AgentTypeShort { get; set; }

    public string? AgentType { get; set; }

    public string? ImageName { get; set; }
}
