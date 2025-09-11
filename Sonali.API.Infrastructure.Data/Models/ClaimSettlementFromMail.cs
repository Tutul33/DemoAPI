using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ClaimSettlementFromMail
{
    public int Id { get; set; }

    public int? PolicyId { get; set; }

    public byte? InstallmentNo { get; set; }

    public string? ClaimType { get; set; }

    public DateOnly? MailDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
