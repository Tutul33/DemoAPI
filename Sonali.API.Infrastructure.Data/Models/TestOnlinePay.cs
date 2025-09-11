using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TestOnlinePay
{
    public int Id { get; set; }

    public string? UrlReferrer { get; set; }

    public string? Fprid { get; set; }

    public string? TestVal { get; set; }

    public DateTime? CreateDate { get; set; }
}
