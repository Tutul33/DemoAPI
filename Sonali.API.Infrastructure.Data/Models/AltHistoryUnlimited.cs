using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AltHistoryUnlimited
{
    public int AltHistoryId { get; set; }

    public int? Fprid { get; set; }

    public int? ApplicantId { get; set; }

    public string? AlterationCase { get; set; }

    public string? AlterationInformation { get; set; }

    public int? AltStatus { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CaseCode { get; set; }
}
