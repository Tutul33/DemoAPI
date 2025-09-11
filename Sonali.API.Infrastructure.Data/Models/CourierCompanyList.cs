using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class CourierCompanyList
{
    public int CourierId { get; set; }

    public string? CourierCompanyName { get; set; }

    public string? ContactNo { get; set; }
}
