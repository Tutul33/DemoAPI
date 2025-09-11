using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class DemoItem
{
    public int Id { get; set; }

    public int? DemoId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Title { get; set; }

    public bool? IsActive { get; set; }
}
