using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ProcessWithCodesMonthWise
{
    public int Id { get; set; }

    public string? ProcessCodesId { get; set; }

    public int? Yr { get; set; }

    public int? Mon { get; set; }

    public string? ProcessName { get; set; }

    public string? Statas { get; set; }

    public string? AgentType { get; set; }

    public string? DrCode { get; set; }

    public string? CrCode { get; set; }

    public double? Bsa { get; set; }

    public double? Entertainment { get; set; }

    public double? PerfBonus { get; set; }

    public double? GrossAmt { get; set; }

    public double? AitAmt { get; set; }

    public double? Pfamt { get; set; }

    public double? NetAmt { get; set; }

    public bool Isposted { get; set; }

    public string? VoucherNo { get; set; }

    public DateOnly? EntryDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateByDate { get; set; }

    public string? UpdateBy { get; set; }
}
