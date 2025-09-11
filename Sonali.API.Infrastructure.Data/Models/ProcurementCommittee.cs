using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ProcurementCommittee
{
    public int Id { get; set; }

    public int? DeptId { get; set; }

    public int? EmpId { get; set; }

    public string? EmpName { get; set; }

    public string? Email { get; set; }

    public string? Createby { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
