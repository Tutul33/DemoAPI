using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class WebUserInfo
{
    public int Sl { get; set; }

    public string? Usertype { get; set; }

    public string? DocumentId { get; set; }

    public string? PolicyId { get; set; }

    public string? Name { get; set; }

    public DateOnly? Dob { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public string? SecQuestion { get; set; }

    public string? Answer { get; set; }
}
