using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AccGl2013C
{
    public decimal Id { get; set; }

    public string? VoucherNo { get; set; }

    public decimal ActCode { get; set; }

    public string? ActName { get; set; }

    public string FromActCode { get; set; } = null!;

    public string ToActCode { get; set; } = null!;

    public decimal Damount { get; set; }

    public decimal Camount { get; set; }

    public decimal Amt { get; set; }

    public string? AccStatement { get; set; }

    public string? Descrp { get; set; }

    public string? ModOfPay { get; set; }

    public string? ChkNo { get; set; }

    public DateTime? ChkDt { get; set; }

    public string OpeningBalance { get; set; } = null!;

    public string? ShopId { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }

    public DateTime? DelDate { get; set; }

    public string? DelUser { get; set; }

    public string? MainCode { get; set; }

    public int? SubGroupCat { get; set; }

    public DateTime? CreateDate { get; set; }
}
