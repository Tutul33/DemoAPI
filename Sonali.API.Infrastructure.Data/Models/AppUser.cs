using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AppUser
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? TypeName { get; set; }

    public int? UserId { get; set; }

    public int? RoleId { get; set; }

    public long? RfId { get; set; }

    public string? UpdateCardBy { get; set; }

    public DateTime? UpdateCardDate { get; set; }
}
