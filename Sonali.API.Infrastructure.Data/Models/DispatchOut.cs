using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class DispatchOut
{
    public int DispatchId { get; set; }

    public string? Purpose { get; set; }

    public string? ReceiverName { get; set; }

    public string? ReceiverAddress { get; set; }

    public DateOnly? DispatchDate { get; set; }

    public string? SenderName { get; set; }

    public string? Department { get; set; }

    public string? Description { get; set; }

    public string? DispatchType { get; set; }

    public int? TrackNo { get; set; }

    public string? DispatchedBy { get; set; }

    public string? CourierCompany { get; set; }

    public double? Amount { get; set; }

    public DateOnly? CourierDate { get; set; }

    public string? CourierTrackNo { get; set; }

    public string? PolicyNo { get; set; }

    public string? PrivilegeCard { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? DispatchOption { get; set; }

    public string? ReceiverEmployeeType { get; set; }

    public int? ReceiverBranchId { get; set; }

    public int? ReceiverId { get; set; }

    public string? MobileNo { get; set; }
}
