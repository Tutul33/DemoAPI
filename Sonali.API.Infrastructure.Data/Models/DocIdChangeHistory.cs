using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class DocIdChangeHistory
{
    public int Id { get; set; }

    public int? FprId { get; set; }

    public int? NomineeId { get; set; }

    public string? OldDocId { get; set; }

    public string? NewDoeId { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
