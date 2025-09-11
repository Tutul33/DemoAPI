using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class GiftInfo
{
    public int Id { get; set; }

    public int? FprId { get; set; }

    public int? NoOfGift { get; set; }

    public DateOnly? GiftDate { get; set; }

    public string? Remarks { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
