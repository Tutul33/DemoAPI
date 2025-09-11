using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class DispatchIn
{
    public int DispatchInId { get; set; }

    public string? SenderName { get; set; }

    public string? ReceiverName { get; set; }

    public string? ReceivedFor { get; set; }

    public string? Department { get; set; }

    public int? TrackNo { get; set; }

    public string? Description { get; set; }

    public DateOnly? ReceiveDate { get; set; }

    public int? Flag { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
