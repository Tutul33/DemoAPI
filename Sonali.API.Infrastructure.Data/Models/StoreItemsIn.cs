using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class StoreItemsIn
{
    public int InId { get; set; }

    public int? StoreItemId { get; set; }

    public int? Quantity { get; set; }

    public int? RecId { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
