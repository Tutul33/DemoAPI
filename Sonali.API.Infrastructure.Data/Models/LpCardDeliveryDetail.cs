using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class LpCardDeliveryDetail
{
    public int Sl { get; set; }

    public string? CardNo { get; set; }

    public string? CardHolderType { get; set; }

    public string? CardHolderName { get; set; }

    public string? MobileNo { get; set; }

    public int? CardTypeId { get; set; }

    public string? CardHolderStatus { get; set; }

    public string? DeliveredByType { get; set; }

    public string? DeliveredBy { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public string? TrackNo { get; set; }

    public string? ActivationCode { get; set; }

    public string? Address { get; set; }

    public string? Comments { get; set; }

    public DateOnly? ActivationDate { get; set; }

    public int? ActivationFlag { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }
}
