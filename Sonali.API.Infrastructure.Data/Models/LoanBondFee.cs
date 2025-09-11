using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class LoanBondFee
{
    public decimal Id { get; set; }

    public decimal? FrmAmt { get; set; }

    public decimal? ToAmt { get; set; }

    public decimal? Fee { get; set; }
}
