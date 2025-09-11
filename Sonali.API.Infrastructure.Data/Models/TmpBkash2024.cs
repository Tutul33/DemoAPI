using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TmpBkash2024
{
    public double? SlNo { get; set; }

    public string? TransectionId { get; set; }

    public DateTime? TransectionDate { get; set; }

    public string? Mobile { get; set; }

    public string? Reference { get; set; }

    public double? Amount { get; set; }

    public string? FromAccountNumber { get; set; }

    public string? ToAccountNumber { get; set; }
}
