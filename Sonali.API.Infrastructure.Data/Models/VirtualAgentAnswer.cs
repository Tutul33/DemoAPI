using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class VirtualAgentAnswer
{
    public int Id { get; set; }

    public int? QuestionId { get; set; }

    public string? Answer { get; set; }

    public string? UserToken { get; set; }
}
