using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ReinsuranceProcess
{
    public int Id { get; set; }

    public int? Fprid { get; set; }

    public int? Eligibility { get; set; }

    public string? Msg { get; set; }
}
