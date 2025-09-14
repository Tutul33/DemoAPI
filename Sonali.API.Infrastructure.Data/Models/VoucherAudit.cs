using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class VoucherAudit
{
    public long AuditId { get; set; }

    public long VoucherId { get; set; }

    public string Action { get; set; } = null!;

    public string? ActionBy { get; set; }

    public DateTime ActionAt { get; set; }

    public string? Details { get; set; }
}
