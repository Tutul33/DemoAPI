using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Circular
{
    public int Id { get; set; }

    public string? CircularTitle { get; set; }

    public string? CircularDetails { get; set; }

    public DateOnly? Deadline { get; set; }

    public string? Docs { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }
}
