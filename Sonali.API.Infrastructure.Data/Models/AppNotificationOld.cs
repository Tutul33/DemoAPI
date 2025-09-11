using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AppNotificationOld
{
    public int NotificationId { get; set; }

    public string? SmsText { get; set; }

    public string? PhoneNo { get; set; }

    public string? AppType { get; set; }

    public string? DocId { get; set; }

    public int? Fprid { get; set; }

    public int? PurposeId { get; set; }

    public string? ReferenceId { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UserName { get; set; }

    public int? StatusFlag { get; set; }
}
