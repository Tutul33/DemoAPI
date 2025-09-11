using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class VendorEnlistmentList
{
    public double? SlNo { get; set; }

    public string? Name { get; set; }

    public string? Binno { get; set; }

    public string? Tinno { get; set; }

    public string? Address { get; set; }

    public string? ContractNo { get; set; }

    public string? Email { get; set; }

    public string? Category { get; set; }

    public double? CategoryId { get; set; }
}
