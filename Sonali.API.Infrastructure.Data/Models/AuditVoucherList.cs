using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AuditVoucherList
{
    public int Id { get; set; }

    public string? VoucherNoMain { get; set; }

    public string? VoucherNo { get; set; }

    public string? ActCode { get; set; }

    public string? ActName { get; set; }

    public string? FromActCode { get; set; }

    public string? ToActCode { get; set; }

    public decimal? Damount { get; set; }

    public decimal? Camount { get; set; }

    public decimal? Amt { get; set; }

    public string? AccStatement { get; set; }

    public string? Descrp { get; set; }

    public string? UserId { get; set; }

    public DateOnly? EntryDate { get; set; }

    public DateOnly? DelDate { get; set; }

    public string? DelUser { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? JournalId { get; set; }

    public string? Excel { get; set; }
}
