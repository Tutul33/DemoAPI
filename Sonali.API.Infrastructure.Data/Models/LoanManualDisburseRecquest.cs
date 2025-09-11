using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class LoanManualDisburseRecquest
{
    public int Id { get; set; }

    public string? DocId { get; set; }

    public string? PolicyHolderName { get; set; }

    public string? PolicyHolderMobile { get; set; }

    public int? CardAssignId { get; set; }

    public double? RecquestAmount { get; set; }

    public string? ApproveStatus { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
