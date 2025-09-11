using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ThanaList
{
    public int Id { get; set; }

    public int? DivisionId { get; set; }

    public int? DistrictId { get; set; }

    public string? ThanaName { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
