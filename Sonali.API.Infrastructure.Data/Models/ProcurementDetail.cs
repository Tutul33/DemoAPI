using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ProcurementDetail
{
    public int Sl { get; set; }

    public int? ProcMasterId { get; set; }

    public string? RequisitionNo { get; set; }

    public DateTime? DeadLine { get; set; }

    public int? DepartmentId { get; set; }

    public int? ProcCategoryId { get; set; }

    public string? ItemName { get; set; }

    public string? ItemDescription { get; set; }

    public int? ReqQuantity { get; set; }

    public int? QtyInHand { get; set; }

    public double? ActualSupplyAmount { get; set; }

    public double? EstimatedPrice { get; set; }

    public string? Remark { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    public int? ProcQuotId { get; set; }

    public string? Status { get; set; }
}
