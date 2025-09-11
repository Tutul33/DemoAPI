using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class BankFlowSetting
{
    public decimal Id { get; set; }

    public string? ActCode { get; set; }

    public string? UserId { get; set; }
}
