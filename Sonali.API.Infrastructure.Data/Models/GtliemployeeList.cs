using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class GtliemployeeList
{
    public int GtliEmployeeListsId { get; set; }

    public string? EmployeeCodeNo { get; set; }

    public string? EmployeeFullName { get; set; }

    public string? CareOfName { get; set; }

    public string? EmployeeDesignation { get; set; }

    public string? JobLocation { get; set; }

    public DateOnly? JoiningDate { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public int? Age { get; set; }

    public string? NidNo { get; set; }

    public double? InsuranceAmount { get; set; }

    public string? NomineeName { get; set; }

    public string? NomineeRelation { get; set; }

    public string? ApplicantPhoto { get; set; }

    public string? NomineePhoto { get; set; }

    public int? GtliId { get; set; }

    public int? GtSlNo { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
