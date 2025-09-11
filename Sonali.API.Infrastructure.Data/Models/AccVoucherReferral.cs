using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AccVoucherReferral
{
    public int Id { get; set; }

    public string? VoucherNo { get; set; }

    public string? RefBy { get; set; }

    public string? RefTo { get; set; }

    public string? RefType { get; set; }

    public string? Comments { get; set; }

    public DateTime? ReferDate { get; set; }

    public bool? IsActive { get; set; }
}
