using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class IncomingSm
{
    public int Id { get; set; }

    public string? SenderNum { get; set; }

    public string? Msg { get; set; }

    public DateTime? CreateDate { get; set; }
}
