using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class SmsLog
{
    public int Smsid { get; set; }

    public string? SmsText { get; set; }

    public string? PhoneNo { get; set; }

    public int? SmsType { get; set; }

    public string? ResponseText { get; set; }

    public int? Fprid { get; set; }

    public int? PurposeId { get; set; }

    public string? ReferenceId { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? MessageId { get; set; }

    public string? CreditBalance { get; set; }

    public string? OptrTxnId { get; set; }
}
