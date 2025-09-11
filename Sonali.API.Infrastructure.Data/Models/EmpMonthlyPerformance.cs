using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class EmpMonthlyPerformance
{
    public int Id { get; set; }

    public int? EmpId { get; set; }

    public int? BranchId { get; set; }

    public int? DepartmentId { get; set; }

    public int? DesignationId { get; set; }

    public double? Jan { get; set; }

    public double? Feb { get; set; }

    public double? March { get; set; }

    public double? April { get; set; }

    public double? May { get; set; }

    public double? June { get; set; }

    public double? July { get; set; }

    public double? Aug { get; set; }

    public double? Sep { get; set; }

    public double? Oct { get; set; }

    public double? Nov { get; set; }

    public double? Dec { get; set; }

    public double? Average { get; set; }

    public double? ProficiencyInRole { get; set; }

    public string? ProfRoleRemarks { get; set; }

    public double? QualityOfWork { get; set; }

    public string? QualityWorkRemarks { get; set; }

    public double? Planning { get; set; }

    public string? PlanningRemarks { get; set; }

    public double? Initiativeness { get; set; }

    public string? InitiativeRemarks { get; set; }

    public double? InterpersonalRelation { get; set; }

    public string? InterpersonalRemarks { get; set; }

    public double? TeamWork { get; set; }

    public string? TeamWorkRemarks { get; set; }

    public double? InclineToLearn { get; set; }

    public string? InclineRemarks { get; set; }

    public double? LeadershipQuality { get; set; }

    public string? LeadershipRemarks { get; set; }

    public double? Manager { get; set; }

    public string? ManagerRemarks { get; set; }

    public double? Md { get; set; }

    public string? Mdremarks { get; set; }

    public double? Chairman { get; set; }

    public string? Chremarks { get; set; }

    public double? FinalAverage { get; set; }

    public int? Year { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
