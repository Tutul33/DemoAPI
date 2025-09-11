using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class IssueTicket
{
    public int TicketId { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? Branch { get; set; }

    public string? Department { get; set; }

    public string? Designation { get; set; }

    public string? Subject { get; set; }

    public string? Detail { get; set; }

    public string? ForwardDept { get; set; }

    public string? ForwardTo { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
