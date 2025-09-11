using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Fachange
{
    public int Id { get; set; }

    public int? PolicyId { get; set; }

    public int? FaidOld { get; set; }

    public int? FaidNew { get; set; }

    public string? ApprovalStatus { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }
}
