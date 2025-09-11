using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ChangeHistory
{
    public int Id { get; set; }

    public string? ForwardingNo { get; set; }

    public DateOnly? ChangeDate { get; set; }

    public bool? LateFeeChangeStatus { get; set; }

    public string? ActionStatus { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
