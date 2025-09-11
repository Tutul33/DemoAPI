using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PolicyHolderContestWinner
{
    public int Sl { get; set; }

    public int? PolicyId { get; set; }

    public string? PolicyHolderName { get; set; }

    public string? DocId { get; set; }

    public string? MobileNo { get; set; }

    public string? PaymentType { get; set; }

    public int? Category { get; set; }

    public int? PrizeNo { get; set; }

    public string? Remarks { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
