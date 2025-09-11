using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TmpUmpclaimError
{
    public int Id { get; set; }

    public int UmpId { get; set; }

    public int FprId { get; set; }

    public string RequestBody { get; set; } = null!;

    public string? ResponseBody { get; set; }

    public byte? Flag { get; set; }

    public string? ClaimStatus { get; set; }

    public byte RequestStatus { get; set; }

    public DateTime PostingDate { get; set; }

    public DateTime? ResponseDate { get; set; }

    public string? ClaimType { get; set; }

    public int? ClaimId { get; set; }

    public byte? Type { get; set; }

    public byte? IsSend { get; set; }
}
