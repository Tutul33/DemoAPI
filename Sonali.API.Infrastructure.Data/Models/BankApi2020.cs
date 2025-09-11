using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class BankApi2020
{
    public int Id { get; set; }

    public string? PolicyId { get; set; }

    public string? PolicyHolder { get; set; }

    public string? Mobile { get; set; }

    public double? Amount { get; set; }

    public string? BankBranch { get; set; }

    public string? Status { get; set; }

    public int? FprId { get; set; }

    public string? AccountNo { get; set; }

    public string? TransectionId { get; set; }

    public string? BankDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? ErpStatus { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? Updatedate { get; set; }

    public string? BankName { get; set; }
}
