using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AppsGrievance
{
    public int Id { get; set; }

    public string? UserType { get; set; }

    public string? UserReference { get; set; }

    public string? ComplainType { get; set; }

    public string? ComplainDetails { get; set; }

    public string? MobileNo { get; set; }

    public string? GrievanceStatus { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
