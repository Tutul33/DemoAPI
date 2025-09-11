using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class YourTableName
{
    public string? ServerTxnId { get; set; }

    public int? ServerResponseCode { get; set; }

    public string? ServerResponseMessage { get; set; }

    public string? DeliveryStatus { get; set; }

    public string? DndMsisdn { get; set; }

    public string? InvalidMsisdn { get; set; }

    public string? A2pDeliveryStatus { get; set; }

    public int? A2pSendSmsBusinessCode { get; set; }

    public string? AnsSendSmsHttpStatus { get; set; }

    public string? AnsSendSmsBusinessCode { get; set; }

    public int? MnoResponseCode { get; set; }

    public string? MnoResponseMessage { get; set; }
}
