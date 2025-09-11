using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class EmpMovementRegister
{
    public int MovementId { get; set; }

    public int? EmpId { get; set; }

    public int? BranchId { get; set; }

    public int? DeptId { get; set; }

    public int? DesigId { get; set; }

    public DateOnly? MovementDate { get; set; }

    public string? FromTime { get; set; }

    public string? ToTime { get; set; }

    public string? Description { get; set; }

    public string? WorkType { get; set; }

    public int? Flag { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? Updatedate { get; set; }
}
