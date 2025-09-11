using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TmpAccGlUmp
{
    public string ActCode { get; set; } = null!;

    public string? AccStatement { get; set; }

    public string? ChkNo { get; set; }

    public DateTime? ChkDt { get; set; }

    public string? ClaimId { get; set; }
}
