using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class MailLog
{
    public int Id { get; set; }

    public string? Recipients { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public int? StatusFlag { get; set; }

    public DateTime? CreateDate { get; set; }
}
