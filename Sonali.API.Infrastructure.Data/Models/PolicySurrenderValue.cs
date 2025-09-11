using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PolicySurrenderValue
{
    public int SurrenderId { get; set; }

    public string? SurOpt { get; set; }

    public string? SurrOptName { get; set; }

    public string? InstRunByComp { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
