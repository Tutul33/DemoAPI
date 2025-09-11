using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class SupplimentryCombination
{
    public int Id { get; set; }

    public int? SuppMasterId { get; set; }

    public int? SuppChildId { get; set; }
}
