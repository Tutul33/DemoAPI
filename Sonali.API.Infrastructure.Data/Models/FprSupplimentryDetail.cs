using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class FprSupplimentryDetail
{
    public int Id { get; set; }

    public int? FprId { get; set; }

    public int? SupplimentryMasterId { get; set; }

    public int? SupplimentryId { get; set; }

    public double? SupplimentryAmount { get; set; }

    public double? SupReinsAmount { get; set; }

    public string? DocId { get; set; }

    public string? PolicyClass { get; set; }

    public string? Age { get; set; }

    public string? Gender { get; set; }

    public int? TermOfYear { get; set; }

    public double? SupRate { get; set; }

    public double? ReinsRate { get; set; }

    public double? ReinsSupPremium { get; set; }

    public double? ClaimAmount { get; set; }

    public double? OtherSupAmount { get; set; }

    public string? SupplimentryStatus { get; set; }

    public string? ReInsurenceType { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateOnly? Dob { get; set; }
}
