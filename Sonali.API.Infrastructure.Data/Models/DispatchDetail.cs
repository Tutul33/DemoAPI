using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class DispatchDetail
{
    public int DispatchId { get; set; }

    public string? ReceiverName { get; set; }

    public string? ReceiverAddress { get; set; }

    public DateOnly? DispatchDate { get; set; }

    public string? SenderName { get; set; }

    public string? Description { get; set; }

    public string? DispatchType { get; set; }

    public string? TrackNo { get; set; }

    public string? DispatchedBy { get; set; }

    public string? DispatchCompany { get; set; }

    public double? Amount { get; set; }

    public int? PrivilegeCard { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
