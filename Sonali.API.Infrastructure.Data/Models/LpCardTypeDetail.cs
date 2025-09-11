using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class LpCardTypeDetail
{
    public int CardTypeId { get; set; }

    public string? CardTypeName { get; set; }

    public double? MinSumAssured { get; set; }

    public string? CardTypeImg { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
