using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class MisscallLog
{
    public int Id { get; set; }

    public string? PhoneNo { get; set; }

    public string? ReceiverName { get; set; }

    public string? ReceiverType { get; set; }

    public string? CallUser { get; set; }

    public DateTime? CallTime { get; set; }

    public string? Department { get; set; }

    public string? Reason { get; set; }

    public string? Extension { get; set; }

    public string? ReferenceNo { get; set; }
}
