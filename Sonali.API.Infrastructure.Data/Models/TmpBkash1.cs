using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TmpBkash1
{
    public DateTime? DateTime { get; set; }

    public double? FromAccountNumber { get; set; }

    public double? ToAccountNumber { get; set; }

    public double? TransactionAmount { get; set; }

    public string? CouponAmount { get; set; }

    public double? TotalTransactioAmount { get; set; }

    public string? TransactionId { get; set; }

    public string? TransactionReference { get; set; }
}
