using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class UmpClaimApiStatus
{
    public int UmpId { get; set; }

    public int FprId { get; set; }

    public string RequestBody { get; set; } = null!;

    public string? ResponseBody { get; set; }

    public byte? Flag { get; set; }

    public string? ClaimStatus { get; set; }

    /// <summary>
    /// 0=Default; 1=Success; 2=Error
    /// </summary>
    public byte RequestStatus { get; set; }

    public DateTime PostingDate { get; set; }

    /// <summary>
    /// 1=ClaimMaster Table; 2=MaturityClaimProcess Table; 3=ClaimStagePaymentList Table
    /// </summary>
    public DateTime? ResponseDate { get; set; }

    public string? ClaimType { get; set; }

    public int? ClaimId { get; set; }

    public byte? Type { get; set; }
}
