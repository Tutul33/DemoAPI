using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class OnlinePaymentLog2019
{
    public int Sl { get; set; }

    public string? TranId { get; set; }

    public string? ValId { get; set; }

    public double? Amount { get; set; }

    public string? CardType { get; set; }

    public double? StoreAmount { get; set; }

    public string? TranCase { get; set; }

    public string? RelationCode { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? DocumentId { get; set; }
}
