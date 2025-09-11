using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class CallUser
{
    public int Id { get; set; }

    public string? CallUser1 { get; set; }

    public string? EnableCategory { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
