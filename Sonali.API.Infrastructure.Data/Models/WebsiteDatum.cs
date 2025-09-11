using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class WebsiteDatum
{
    public int Id { get; set; }

    public int? GroupClaims { get; set; }

    public int? Claims { get; set; }

    public int? Agents { get; set; }

    public int? Branches { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
