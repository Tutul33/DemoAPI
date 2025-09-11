using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class UploadFile
{
    public int Id { get; set; }

    public string? FileType { get; set; }

    public string? FileName { get; set; }

    public int? FprId { get; set; }

    public string? DocId { get; set; }

    public string? StatusFlag { get; set; }

    public DateTime? CreateDate { get; set; }
}
