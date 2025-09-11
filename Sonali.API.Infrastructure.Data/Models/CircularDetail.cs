using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class CircularDetail
{
    public int Id { get; set; }

    public int? CircularMasterId { get; set; }

    public string? CircularDetails { get; set; }

    public DateTime? Deadline { get; set; }

    public string? UploadDocs { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
