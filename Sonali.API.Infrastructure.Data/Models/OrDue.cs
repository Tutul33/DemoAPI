using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class OrDue
{
    public int Sl { get; set; }

    public int? Fprid { get; set; }

    public int? InsNo { get; set; }

    public string? OrType { get; set; }

    public int? NthYr { get; set; }

    public DateOnly? DueDate { get; set; }

    public DateOnly? RecDate { get; set; }

    public int? OrEntryId { get; set; }
}
