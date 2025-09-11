using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class LpCardDetail
{
    public long Sl { get; set; }

    public string? CardNo { get; set; }

    public string? DocId { get; set; }

    public int? CardTypeId { get; set; }

    public string? PolicyIdz { get; set; }

    public int? ReissueId { get; set; }

    public int? SupCardId { get; set; }

    public string? CardHolderType { get; set; }

    public string? CardHolderName { get; set; }

    public DateOnly? IssueDate { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public string? MemberSince { get; set; }

    public int ActiveFlag { get; set; }

    public string? IssuedBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
