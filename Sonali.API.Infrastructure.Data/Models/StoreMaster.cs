using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class StoreMaster
{
    public int StoreMasterId { get; set; }

    public int? StoreItemId { get; set; }

    public int? Quantity { get; set; }
}
