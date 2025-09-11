using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class BackToPrRequest
{
    public int Id { get; set; }

    public int? ApplicantId { get; set; }

    public string? Comments { get; set; }

    public string? StatusFlag { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
