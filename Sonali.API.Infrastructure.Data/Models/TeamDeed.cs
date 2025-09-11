using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TeamDeed
{
    public int Id { get; set; }

    public int? TeamLeaderId { get; set; }

    public string? TeamName { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
