using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class RecievableList
{
    public int Sl { get; set; }

    public int? ApplicantId { get; set; }

    public int? Fprid { get; set; }

    public int InsNo { get; set; }

    public string? Purpose { get; set; }

    public DateOnly? RecDate { get; set; }

    public double? RecAmt { get; set; }

    public int? Done { get; set; }
}
