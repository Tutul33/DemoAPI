using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ShareDetail
{
    public decimal Id { get; set; }

    public decimal? MasterId { get; set; }

    public decimal? ShareHolderId { get; set; }

    public DateOnly? EntryDate { get; set; }

    public int? BuyQty { get; set; }

    public int? SellQty { get; set; }

    public decimal? TransferParty { get; set; }

    public decimal? Fv { get; set; }

    public decimal? TransactionVal { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
