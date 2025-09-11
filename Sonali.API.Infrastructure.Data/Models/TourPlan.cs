using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TourPlan
{
    public int TravelId { get; set; }

    public int? TourId { get; set; }

    public int? EmpId { get; set; }

    public int? AgentId { get; set; }

    public string? Designation { get; set; }

    public string? ProjectName { get; set; }

    public string? Place { get; set; }

    public string? BranchId { get; set; }

    public string? Purpose { get; set; }

    public string? Trasport { get; set; }

    public DateOnly? TravelDate { get; set; }

    public double? TransportCost { get; set; }

    public double? TravelCost { get; set; }

    public int? Duration { get; set; }

    public double? TargetPremium { get; set; }

    public int? TargetManPower { get; set; }

    public int? Flag { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
