using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class UserHistory
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? Ip { get; set; }

    public DateTime? LogIn { get; set; }

    public DateTime? LogOut { get; set; }

    public string? TypeName { get; set; }
}
