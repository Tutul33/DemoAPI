using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class DailyCashTransaction2025
{
    public int Id { get; set; }

    public int? Amount { get; set; }

    public string? EntryUser { get; set; }

    public DateTime? TxDate { get; set; }

    public string? TxType { get; set; }

    public int? BranchId { get; set; }

    public string? BranchName { get; set; }

    public string? EmpName { get; set; }

    public string? ForwardingNo { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Note { get; set; }
}
