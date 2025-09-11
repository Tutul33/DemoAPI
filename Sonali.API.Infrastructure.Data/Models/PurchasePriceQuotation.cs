using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PurchasePriceQuotation
{
    public int Id { get; set; }

    public int? ReqisitionId { get; set; }

    public int? VendorId { get; set; }

    public string? VendorName { get; set; }

    public string? VendorPriceDoc { get; set; }

    public int? Quantity { get; set; }

    public double? UnitPrice { get; set; }

    public double? TotalPrice { get; set; }

    public string? StatusFlag { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
