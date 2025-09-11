using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class UserFromOnline
{
    public int UserId { get; set; }

    public string? Name { get; set; }

    public DateOnly? Birtday { get; set; }

    public string? Gender { get; set; }

    public string? Email { get; set; }
}
