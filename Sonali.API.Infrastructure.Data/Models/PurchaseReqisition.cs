using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PurchaseReqisition
{
    public int Id { get; set; }

    public int? RelationId { get; set; }

    public string? PurchaseType { get; set; }

    public DateOnly? Dateline { get; set; }

    public int? ItemTypeId { get; set; }

    public string? ItemTypeName { get; set; }

    public int? ItemId { get; set; }

    public string? ItemName { get; set; }

    public int? Quantity { get; set; }

    public string? StatusFlag { get; set; }

    public int? TotalReceivedQuantity { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
