using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class LogTable
{
    public int Id { get; set; }

    public string? Error { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Comment { get; set; }
}
