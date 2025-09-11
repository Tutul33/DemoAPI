using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class GrievanceManagement
{
    public int Id { get; set; }

    public string? Category { get; set; }

    public string? QueryBy { get; set; }

    public int? PolicyAgentId { get; set; }

    public string? CountryCode { get; set; }

    public string? MobileNo { get; set; }

    public int? GrievanceTypeId { get; set; }

    public string? ComplainDetails { get; set; }

    public DateOnly? ComplainDate { get; set; }

    public string? ComplainStatus { get; set; }

    public DateOnly? TurnaroundTime { get; set; }

    public string? ReferToType { get; set; }

    public int? ReferToId { get; set; }

    public string? ResolveDetails { get; set; }

    public DateOnly? ResolveDate { get; set; }

    public int? ResolveById { get; set; }

    public string? ReferToUserName { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
