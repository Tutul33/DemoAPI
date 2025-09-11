using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class StoreItemsOut
{
    public int OutId { get; set; }

    public int? StoreItemId { get; set; }

    public int? Quantity { get; set; }

    public double? UnitPrice { get; set; }

    public double? TotalAmount { get; set; }

    public string? IssueFor { get; set; }

    public int? EmpId { get; set; }

    public string? EmpType { get; set; }

    public int? StatusFlag { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
