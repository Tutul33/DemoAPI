using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ApplicantApprovalUser
{
    public int Id { get; set; }

    public int? EmpId { get; set; }

    public string? UserName { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
