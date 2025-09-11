using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class DocumentList
{
    public int Id { get; set; }

    public string? PolicyNo { get; set; }

    public string? ClaimType { get; set; }

    public int? DocTypeId { get; set; }

    public string? Blobfile { get; set; }

    public string CreateBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }
}
