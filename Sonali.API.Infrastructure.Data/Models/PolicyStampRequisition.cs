using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PolicyStampRequisition
{
    public int Sl { get; set; }

    public int? CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public int? Quantity { get; set; }

    public double? Amount { get; set; }

    public DateOnly? RequisitionDate { get; set; }

    public string? Comments { get; set; }

    public string? ReferTo { get; set; }

    public int? Flag { get; set; }

    public int? PurchaseFlag { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? GroupId { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
