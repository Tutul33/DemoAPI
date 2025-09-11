using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AssetAssign
{
    public int AssetAssignId { get; set; }

    public int? AssetNameId { get; set; }

    public int? Quantity { get; set; }

    public int? AssignBranchId { get; set; }

    public int? AssignDepId { get; set; }

    public int? AssignEmpType { get; set; }

    public int? AssignUserId { get; set; }

    public DateOnly? AssignDate { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
