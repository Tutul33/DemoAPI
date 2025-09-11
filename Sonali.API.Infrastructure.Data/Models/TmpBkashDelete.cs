using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TmpBkashDelete
{
    public int? SlNo { get; set; }

    public string? TransectionId { get; set; }

    public DateTime? TransectionDate { get; set; }

    public string? Mobile { get; set; }

    public string? Reference { get; set; }

    public int? Amount { get; set; }

    public string? FromAccountNumber { get; set; }

    public string? ToAccountNumber { get; set; }
}
