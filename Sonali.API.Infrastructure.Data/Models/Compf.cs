using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Compf
{
    public int Sl { get; set; }

    public string Agent { get; set; } = null!;

    public string Fpr { get; set; } = null!;

    public string Pr { get; set; } = null!;

    public int Pf { get; set; }

    public int Done { get; set; }
}
