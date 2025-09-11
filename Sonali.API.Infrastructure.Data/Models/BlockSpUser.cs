using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class BlockSpUser
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? Spname { get; set; }

    public DateTime? LastUpdate { get; set; }
}
