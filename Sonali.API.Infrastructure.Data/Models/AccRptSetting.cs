using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AccRptSetting
{
    public decimal Id { get; set; }

    public string? Name { get; set; }

    public string? Rpt { get; set; }
}
