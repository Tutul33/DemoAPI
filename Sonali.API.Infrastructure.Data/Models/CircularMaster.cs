using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class CircularMaster
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public DateTime? CircularDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
