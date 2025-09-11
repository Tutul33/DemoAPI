using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class LpMerchantDetail
{
    public int DetailId { get; set; }

    public int? CategoryId { get; set; }

    public int? MerchantId { get; set; }

    public string? Detail { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
