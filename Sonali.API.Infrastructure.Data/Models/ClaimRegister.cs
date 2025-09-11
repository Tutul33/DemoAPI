using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ClaimRegister
{
    public int ClmRegId { get; set; }

    public int? ClaimId { get; set; }

    public byte? ClaimType { get; set; }

    public int? Fprid { get; set; }

    public string? ModeOfPayment { get; set; }

    public string? VoucherNo { get; set; }

    public string? CreateBy { get; set; }

    public DateTime CreateDate { get; set; }

    public string? Remarks { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
