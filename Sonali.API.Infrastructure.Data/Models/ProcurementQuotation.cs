using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ProcurementQuotation
{
    public int Id { get; set; }

    public int? ProcDetailId { get; set; }

    public int? VendorId { get; set; }

    public string? FileName { get; set; }

    public double? QuotationPrice { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreatedBy { get; set; }
}
