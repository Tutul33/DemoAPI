using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PayPageObjectRole
{
    public int PageObjAccId { get; set; }

    public int? RoleId { get; set; }

    public int? PageObjectId { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public string? UpdateDate { get; set; }
}
