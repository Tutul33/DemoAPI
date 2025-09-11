using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Complain
{
    public int Id { get; set; }

    public int? CategoryId { get; set; }

    public int? DeptId { get; set; }

    public int? Fprid { get; set; }

    public string? Description { get; set; }

    public DateOnly? ComplainDate { get; set; }

    public DateOnly? ResolveDate { get; set; }

    public string? ResolvedBy { get; set; }

    public string? Status { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
