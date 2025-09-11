using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class CourierServiceSetup
{
    public int Sl { get; set; }

    public string? CourierName { get; set; }

    public string? CourierAddress { get; set; }

    public string? CourierContactNo { get; set; }

    public string? CourierEmail { get; set; }

    public string? CourierWebsite { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }
}
