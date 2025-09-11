using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Dprrate
{
    public byte Age { get; set; }

    public string Male { get; set; } = null!;

    public string Female { get; set; } = null!;

    public string? Type { get; set; }
}
