using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class MobileEmailChange
{
    public int Sl { get; set; }

    public int? Fprid { get; set; }

    public string? PrevMobileNo { get; set; }

    public string? NewMobileNo { get; set; }

    public string? PrevEmail { get; set; }

    public string? NewEmail { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
