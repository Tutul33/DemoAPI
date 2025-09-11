using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ReinsuranceRegister
{
    public int RegisterId { get; set; }

    public string? Company { get; set; }

    public string? Description { get; set; }

    public double? ReceivableAmount { get; set; }

    public double? PayableAmount { get; set; }

    public string? Comments { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
