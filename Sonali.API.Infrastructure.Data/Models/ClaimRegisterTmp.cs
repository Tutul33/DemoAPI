using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ClaimRegisterTmp
{
    public int Id { get; set; }

    public int? ClaimId { get; set; }

    public int ClaimType { get; set; }

    public int? Fprid { get; set; }

    public string ModeOfPayment { get; set; } = null!;

    public string? VoucherNo { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Remarks { get; set; }

    public byte IsExport { get; set; }
}
