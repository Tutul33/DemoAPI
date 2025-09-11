using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class LpMerchantName
{
    public int MerchantId { get; set; }

    public int? CategoryId { get; set; }

    public string? MerchantName { get; set; }

    public string? MerchantImage { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
