using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class DeathClaimOthersDocument
{
    public int Id { get; set; }

    public int? ClaimId { get; set; }

    public string? DocumentName { get; set; }

    public DateOnly? Date { get; set; }

    public string? Comment { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
