using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class CbsilconsolidatedCustomer
{
    public string? VoucherNo { get; set; }

    public string? ActCode { get; set; }

    public string? ActName { get; set; }

    public string? FromActCode { get; set; }

    public string? ToActCode { get; set; }

    public double? Damount { get; set; }

    public double? Camount { get; set; }

    public double? Amt { get; set; }

    public string? AccStatement { get; set; }

    public string? Descrp { get; set; }

    public string? UserId { get; set; }

    public string? EntryDate { get; set; }

    public string? DelDate { get; set; }

    public string? DelUser { get; set; }

    public string? CreateDate { get; set; }
}
