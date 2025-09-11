using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Smrupdate
{
    public int Id { get; set; }

    public int Year { get; set; }

    public string? PaymentType { get; set; }

    public double? Amount { get; set; }

    public string? TrxnId { get; set; }

    public string? ActCode { get; set; }
}
