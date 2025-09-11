using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AgentJobDetailsDeleted
{
    public int AgentId { get; set; }

    public int? AentTypeId { get; set; }

    public int? RoleId { get; set; }

    public int? AgentHirearchyId { get; set; }

    public string? AgentJobStatus { get; set; }

    public string? UnitOfficeCode { get; set; }

    public string? LicenseStatus { get; set; }

    public string? IdraregistrationNo { get; set; }

    public DateOnly? LicenseExpiryDate { get; set; }

    public string? BranchOfficeCode { get; set; }

    public DateTime? JobStartDate { get; set; }

    public DateTime? JobEndDate { get; set; }

    public string? AgentIdNo { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? RecruitBy { get; set; }

    public string? ActivateBy { get; set; }

    public DateTime? ActivateDate { get; set; }

    public DateTime? PostingDate { get; set; }
}
