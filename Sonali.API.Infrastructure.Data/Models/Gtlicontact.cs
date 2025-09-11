using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Gtlicontact
{
    public int ContactId { get; set; }

    public string? ContactName { get; set; }

    public string? ContactDesignation { get; set; }

    public string? ContactMobileNo { get; set; }

    public string? ContactEmailAddress { get; set; }

    public int? GtliId { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
