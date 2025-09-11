using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Eftnrecord
{
    public decimal Id { get; set; }

    public int? Fprid { get; set; }

    public int? InstallmentTypeId { get; set; }

    public int? TermofYear { get; set; }

    public DateOnly? EftnstartDate { get; set; }

    public DateOnly? LastEftnpaymentDate { get; set; }

    public string? CreditBank { get; set; }

    public string? CreditBankName { get; set; }

    public string? CustBank { get; set; }

    public string? CustBankName { get; set; }

    public string? CustBankAcno { get; set; }

    public string? RoutingNo { get; set; }

    public string? CustBankAcname { get; set; }

    public string? AgentId { get; set; }

    public string? BranchId { get; set; }

    public double? PremiumAmount { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? ActiveStatus { get; set; }
}
