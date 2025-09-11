using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class BgmeaworkerList
{
    public int Id { get; set; }

    public int? GtliId { get; set; }

    public string? SlNo { get; set; }

    public string? EmployeeName { get; set; }

    public string? Designation { get; set; }

    public string? Idnumber { get; set; }

    public string? DateOfBirth { get; set; }

    public string? DateOfJoining { get; set; }

    public string? Remarks { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
