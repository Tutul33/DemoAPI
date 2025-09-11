using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class GtlistudentList
{
    public int Id { get; set; }

    public int? GtliId { get; set; }

    public int? GtSlNo { get; set; }

    public string? StudentFullName { get; set; }

    public int? StudentAge { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? BirthCertificateNo { get; set; }

    public string? LegalGuardianName { get; set; }

    public int? LegalGuardianAge { get; set; }

    public string? LegalGuardianDoc { get; set; }

    public double? MonthlyStipendAmount { get; set; }

    public double? PremiumAmount { get; set; }

    public string? StudentPhoto { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
