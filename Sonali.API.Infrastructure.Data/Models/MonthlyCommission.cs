using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class MonthlyCommission
{
    public int Id { get; set; }

    public string? CompositeId { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public string? AgentType { get; set; }

    public double? Comm { get; set; }

    public double? Ait { get; set; }

    public double? Pf { get; set; }

    public string? PolicyStatus { get; set; }

    public string? Maker { get; set; }

    public string? Checker { get; set; }

    public string? Approver { get; set; }

    public DateOnly? ApprovingDate { get; set; }

    public DateOnly? PostingDate { get; set; }

    public string? PostToAccount { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? VoucherNo { get; set; }

    public string? Subject { get; set; }
}
