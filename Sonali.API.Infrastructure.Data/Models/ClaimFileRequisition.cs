using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ClaimFileRequisition
{
    public int ReqId { get; set; }

    public string? Purpose { get; set; }

    public int? PolicyId { get; set; }

    public DateOnly? RequisitionDate { get; set; }

    public string? RequisitionTo { get; set; }

    public int? ReqFlag { get; set; }

    public int? OutFlag { get; set; }

    public DateOnly? OutDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? EmployeeId { get; set; }
}
