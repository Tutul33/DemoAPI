using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AlterationCase
{
    public string CaseId { get; set; } = null!;

    public string? CaseName { get; set; }
}
