using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class WebQuoteTable
{
    public int Sl { get; set; }

    public int? Cid { get; set; }

    public string? Cname { get; set; }

    public string? Cemail { get; set; }

    public int? CcontactNo { get; set; }

    public int? Ciplan { get; set; }

    public int? CipolicyAmount { get; set; }

    public DateTime? CreateDate { get; set; }
}
