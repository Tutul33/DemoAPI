using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class FdrdateList
{
    public decimal Sl { get; set; }

    public DateOnly? Dt { get; set; }

    public int Days { get; set; }
}
