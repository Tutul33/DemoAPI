using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class WrongEntry
{
    public int Id { get; set; }

    public string? TrnNo { get; set; }

    public DateTime? Edate { get; set; }
}
