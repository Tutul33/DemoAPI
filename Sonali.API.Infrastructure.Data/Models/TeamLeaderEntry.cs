using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TeamLeaderEntry
{
    public int Id { get; set; }

    public int? EmpId { get; set; }

    public int? Samdid { get; set; }

    public int? Amdid { get; set; }

    public int? Sgmid { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
