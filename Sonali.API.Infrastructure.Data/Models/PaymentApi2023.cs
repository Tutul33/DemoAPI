using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PaymentApi2023
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

    public string? Token { get; set; }

    public string? ForwardingNo { get; set; }

    public string? ResponseNo { get; set; }

    public int? Faid { get; set; }

    public string? Faname { get; set; }

    public int? Umid { get; set; }

    public string? Umname { get; set; }

    public int? Bmid { get; set; }

    public string? Bmname { get; set; }

    public int? MonthValue { get; set; }
}
