using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class UpdateDeleteType
{
    public int Id { get; set; }

    public string? Udtype { get; set; }

    public string? Spname { get; set; }

    public int? DeptId { get; set; }
}
