using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Pfcompany
{
    public int CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public int? NoOfEmployee { get; set; }

    public string? CompanyAddress { get; set; }

    public string? MobileNo { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
