using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class RankingFrenquency
{
    public decimal Id { get; set; }

    public string? UserName { get; set; }

    public string? RptName { get; set; }

    public string? AgentType { get; set; }

    public string? SamdId { get; set; }

    public string? BranchId { get; set; }

    public string? Mf { get; set; }

    public string? Mt { get; set; }

    public string? Yf { get; set; }

    public string? Yt { get; set; }

    public DateTime CreateDate { get; set; }
}
