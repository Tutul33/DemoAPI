using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class WebDptEmployee
{
    public int Id { get; set; }

    public int? EmpId { get; set; }

    public string? ShowStatus { get; set; }

    public string? DesignationName { get; set; }

    public int? DesignationId { get; set; }
}
