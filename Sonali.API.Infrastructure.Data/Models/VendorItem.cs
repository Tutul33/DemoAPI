using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class VendorItem
{
    public int Id { get; set; }

    public int? VendorId { get; set; }

    public string? ItemCategory { get; set; }

    public int? ItemId { get; set; }

    public string? ItemName { get; set; }

    public int? ItemTypeId { get; set; }

    public string? ItemTypeName { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
