using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class LoanDocument
{
    public int Id { get; set; }

    public string? DocId { get; set; }

    public string? PolicyHolderName { get; set; }

    public string? DocName { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? DocType { get; set; }

    public string? DocTypeDesc { get; set; }
}
