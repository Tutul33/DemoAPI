using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class IssueTicketErp
{
    public int TicketId { get; set; }

    public int? EmpId { get; set; }

    public string? EmpType { get; set; }

    public int? DesignationId { get; set; }

    public int? DeptId { get; set; }

    public int? BranchId { get; set; }

    public string? IssueSubject { get; set; }

    public string? IssueDetails { get; set; }

    public string? IssueImage { get; set; }

    public string? IssueStatus { get; set; }

    public string? Remarks { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? SubmitTo { get; set; }
}
