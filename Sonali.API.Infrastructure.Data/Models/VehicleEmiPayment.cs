using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class VehicleEmiPayment
{
    public int EmiPaymentId { get; set; }

    public int? VehicleEmiId { get; set; }

    public double? LoanAmount { get; set; }

    public double? AdjFromAllowance { get; set; }

    public double? AdjFromSalary { get; set; }

    public double? InstallmentPaid { get; set; }

    public int? InstallmentNo { get; set; }

    public DateOnly? PayDate { get; set; }

    public double? LoanRemaining { get; set; }

    public string? Comments { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
