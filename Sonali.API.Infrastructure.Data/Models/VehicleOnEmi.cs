using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class VehicleOnEmi
{
    public int VehicleEmiId { get; set; }

    public int? AssetTypeId { get; set; }

    public int? AssetNameId { get; set; }

    public string? RegistrationNo { get; set; }

    public int? BranchId { get; set; }

    public string? EmpType { get; set; }

    public int? EmpId { get; set; }

    public DateOnly? AssignDate { get; set; }

    public double? NetAmount { get; set; }

    public double? RegCost { get; set; }

    public double? TotalAmount { get; set; }

    public double? DownPayment { get; set; }

    public double? LoanAmount { get; set; }

    public int? NoOfInstallment { get; set; }

    public double? InstallmentAmount { get; set; }

    public double? LoanRemaining { get; set; }

    public DateOnly? LoanEndDate { get; set; }

    public int? Flag { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
