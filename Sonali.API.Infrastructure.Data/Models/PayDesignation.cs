using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PayDesignation
{
    public int DesignationId { get; set; }

    public int? DeptId { get; set; }

    public int? PayScaleId { get; set; }

    public string? DesignationName { get; set; }

    public string? DesignationShortFrom { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? DesignationOrder { get; set; }
}
