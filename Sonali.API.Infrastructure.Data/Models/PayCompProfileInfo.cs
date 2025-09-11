using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PayCompProfileInfo
{
    public int CompProId { get; set; }

    public string? CompProName { get; set; }

    public string? CompAddress { get; set; }

    public string? CompPhone { get; set; }

    public string? CompMobile1 { get; set; }

    public string? CompMobile2 { get; set; }

    public string? Fax { get; set; }

    public string? CompEmail { get; set; }

    public string? CompWebsite { get; set; }

    public string? CompPflogo { get; set; }

    public string? CompPfimage { get; set; }

    public string? CompDescription { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
