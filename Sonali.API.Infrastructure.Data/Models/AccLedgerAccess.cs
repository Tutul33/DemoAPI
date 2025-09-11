using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AccLedgerAccess
{
    public decimal Id { get; set; }

    public string? UserName { get; set; }

    public string? ActCode { get; set; }
}
