using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class VirtualAgentQuestion
{
    public int Id { get; set; }

    public string? TitleEn { get; set; }

    public string? TitleBn { get; set; }

    public string? AnsType { get; set; }

    public string? Category { get; set; }

    public int? QuestionSl { get; set; }

    public string? ToolTip { get; set; }
}
