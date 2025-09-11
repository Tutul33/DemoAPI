using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PolicyStampUsage
{
    public int Sl { get; set; }

    public int? Fprid { get; set; }

    public string? CategoryName { get; set; }

    public int? Quantity { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Comments { get; set; }
}
