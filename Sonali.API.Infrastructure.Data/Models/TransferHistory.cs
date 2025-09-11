using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TransferHistory
{
    public decimal Sl { get; set; }

    public DateOnly? Df { get; set; }

    public DateOnly? Dt { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }
}
