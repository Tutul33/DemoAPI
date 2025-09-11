using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class EmpJobDescription
{
    public int JobDescriptionId { get; set; }

    public int? EmpId { get; set; }

    public int? DesignationId { get; set; }

    public int? DepartmentId { get; set; }

    public string? JobDescription { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
