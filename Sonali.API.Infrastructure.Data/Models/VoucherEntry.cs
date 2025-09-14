using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class VoucherEntry
{
    public long EntryId { get; set; }

    public long VoucherId { get; set; }

    public int AccountHeadId { get; set; }

    public int? SubLedgerId { get; set; }

    public decimal Debit { get; set; }

    public decimal Credit { get; set; }

    public string? Description { get; set; }

    public int LineOrder { get; set; }

    public decimal? SignedAmount { get; set; }

    public virtual AccountHead AccountHead { get; set; } = null!;

    public virtual SubLedger? SubLedger { get; set; }

    public virtual VoucherHeader Voucher { get; set; } = null!;
}
