using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AccVoucherAuth
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? Role { get; set; }
}
