using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class RecurringJournal
{
    public int Id { get; set; }

    public int? RecuId { get; set; }

    public int? ActCode { get; set; }

    public decimal? Dr { get; set; }

    public decimal? Cr { get; set; }

    public string? Memo { get; set; }
}
