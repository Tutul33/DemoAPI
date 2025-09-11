using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ShareTransfer
{
    public int Id { get; set; }

    public int? BuySl { get; set; }

    public string? OldActCode { get; set; }

    public string? NewActCode { get; set; }

    public string? Type { get; set; }
}
