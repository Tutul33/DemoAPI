using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class IpphoneContact
{
    public int Id { get; set; }

    public int? BranchId { get; set; }

    public int? DepartmentId { get; set; }

    public int? DesignationId { get; set; }

    public string? Type { get; set; }

    public int? EmployeeId { get; set; }

    public int? AgentId { get; set; }

    public int? Ipextension { get; set; }

    public string? Email { get; set; }

    public string? MobileNo { get; set; }

    public string? Comment { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
