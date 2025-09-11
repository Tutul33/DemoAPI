using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PurchaseProductReceive
{
    public int Id { get; set; }

    public int? ReqisitionId { get; set; }

    public int? VendorId { get; set; }

    public int? Quantity { get; set; }

    public DateOnly? ReceiveDate { get; set; }

    public string? StatusFlag { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
