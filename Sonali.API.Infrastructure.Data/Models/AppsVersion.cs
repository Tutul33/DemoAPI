using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AppsVersion
{
    public int Id { get; set; }

    public string? AppName { get; set; }

    public int? VersionNo { get; set; }

    public string? Msg { get; set; }
}
