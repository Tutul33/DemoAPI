using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AccTempCheck
{
    public decimal Id { get; set; }

    public string ActCode { get; set; } = null!;

    public string? ActName { get; set; }

    public decimal Damount { get; set; }

    public decimal Camount { get; set; }

    public decimal Amt { get; set; }

    public string? AccStatement { get; set; }

    public string? Descrp { get; set; }

    public string? ModOfPay { get; set; }

    public string? ChkNo { get; set; }

    public DateTime? ChkDt { get; set; }

    public string? UserId { get; set; }
}
