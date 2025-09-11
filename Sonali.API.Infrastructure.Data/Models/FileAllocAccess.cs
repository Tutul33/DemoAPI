using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class FileAllocAccess
{
    public int Id { get; set; }

    public int? EmpId { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? DeletBy { get; set; }

    public DateTime? DeleteDate { get; set; }
}
