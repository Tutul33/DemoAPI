using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Disbursement
{
    public int Id { get; set; }

    public int ClaimId { get; set; }

    public string? ClaimType { get; set; }

    public string? TransactionId { get; set; }

    public int Amount { get; set; }

    public string CreateBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }
}
