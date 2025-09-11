using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PolicyToDeed
{
    public int Id { get; set; }

    public int? Fprid { get; set; }

    public int? TeamId { get; set; }

    public int? GroupId { get; set; }

    public DateOnly? Fprdate { get; set; }

    public DateOnly? CreateDate { get; set; }

    public DateOnly? ReceivedDate { get; set; }

    public DateOnly? RejectDate { get; set; }

    public DateOnly? FileReturnDate { get; set; }

    public string? Comments { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? StampDeliveryDate { get; set; }
}
