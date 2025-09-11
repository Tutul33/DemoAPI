using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ExcludeFromReinsurance
{
    public int Id { get; set; }

    public int? Fprid { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }
}
