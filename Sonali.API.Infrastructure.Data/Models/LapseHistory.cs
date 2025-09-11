using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class LapseHistory
{
    public int Id { get; set; }

    public int? FprId { get; set; }

    public int? InsNo { get; set; }

    public DateOnly? LapseDate { get; set; }

    public string? Flag { get; set; }

    public DateOnly? RevivedDate { get; set; }

    public DateOnly? CommencementDate { get; set; }

    public int ClaimFlag { get; set; }
}
