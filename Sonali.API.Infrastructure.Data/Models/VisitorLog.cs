using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class VisitorLog
{
    public int VisitId { get; set; }

    public string? VisitorName { get; set; }

    public string? VisitorCompany { get; set; }

    public string? VisitorMobile { get; set; }

    public string? VisitorAddress { get; set; }

    public string? Purpose { get; set; }

    public int? VisitTo { get; set; }

    public DateOnly? VisitDate { get; set; }

    public string? FromTime { get; set; }

    public string? ToTime { get; set; }

    public string? Status { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
