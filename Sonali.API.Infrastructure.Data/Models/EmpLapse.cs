using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class EmpLapse
{
    public int Id { get; set; }

    public int? EmpId { get; set; }

    public string? EmpName { get; set; }

    public int? DesignationId { get; set; }

    public string? DesignationName { get; set; }

    public int? DeptId { get; set; }

    public string? Deptname { get; set; }

    public int? BranchId { get; set; }

    public string? BranchName { get; set; }

    public string? DocId { get; set; }

    public string? MobileNo { get; set; }

    public int? LapsePolicy { get; set; }

    public string? UserName { get; set; }

    public DateTime? CreateDate { get; set; }
}
