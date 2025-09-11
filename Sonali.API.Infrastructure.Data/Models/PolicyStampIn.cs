using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PolicyStampIn
{
    public int Sl { get; set; }

    public int? RequisitionId { get; set; }

    public string? CategoryName { get; set; }

    public int? RequisitionQty { get; set; }

    public int? ReceivedQty { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? GroupId { get; set; }

    public DateOnly? PurchaseDate { get; set; }
}
