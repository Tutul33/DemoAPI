using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Accgl2020
{
    public decimal Id { get; set; }

    public string? VoucherNo { get; set; }

    public string ActCode { get; set; } = null!;

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

    public string? OpeningBalance { get; set; }

    public string? ShopId { get; set; }

    public string? UserId { get; set; }

    public DateOnly? EntryDate { get; set; }

    public DateTime? DelDate { get; set; }

    public string? DelUser { get; set; }

    public string? MainCode { get; set; }

    public int? SubGroupCat { get; set; }

    public int Transfered { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? AuthStatus { get; set; }

    public string? CheckedBy { get; set; }

    public DateTime? CheckedDate { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedDate { get; set; }
}
