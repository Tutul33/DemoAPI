using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class LoginUserList
{
    public int UserId { get; set; }

    public int Uid { get; set; }

    public string UserName { get; set; } = null!;

    public bool IsBlock { get; set; }

    public DateTime CreateDate { get; set; }
}
