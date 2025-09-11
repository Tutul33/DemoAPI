using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class OnlineUser
{
    public int OnlineUserId { get; set; }

    public string UserName { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public string DocId { get; set; } = null!;

    public int PolicyId { get; set; }

    public int? SecretQuestion { get; set; }

    public string? SecretAns { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}
