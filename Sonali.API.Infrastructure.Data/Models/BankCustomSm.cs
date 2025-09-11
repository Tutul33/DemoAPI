using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class BankCustomSm
{
    public int ConId { get; set; }

    public int? SmsId { get; set; }

    public string? AccNo { get; set; }

    public string? TranType { get; set; }

    public double? Amount { get; set; }

    public DateTime? CreatedDate { get; set; }
}
