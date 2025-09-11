using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AlterPayment
{
    public int AltPaymentId { get; set; }

    public int? FprId { get; set; }

    public int? AppId { get; set; }

    public int AltPol { get; set; }

    public string AltHis { get; set; } = null!;

    public double AdjAmt { get; set; }

    public double AltFees { get; set; }

    public double TotalAmount { get; set; }

    public double TotalDeposit { get; set; }

    public double Suspense { get; set; }

    public double PrevSuspense { get; set; }

    public int IsPaid { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public string? PaymentMethod { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
