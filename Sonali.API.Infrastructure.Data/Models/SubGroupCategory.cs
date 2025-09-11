using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class SubGroupCategory
{
    public int SubGroupCatId { get; set; }

    public string? SubGroupCatName { get; set; }

    public int? GroupCatId { get; set; }

    public string? Year { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
