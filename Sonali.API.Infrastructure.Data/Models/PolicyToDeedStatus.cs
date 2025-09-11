using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PolicyToDeedStatus
{
    public int Id { get; set; }

    public int? Status { get; set; }

    public string? Description { get; set; }
}
