using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class InvTypeEntry
{
    public int Id { get; set; }

    public string TypeName { get; set; } = null!;

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public virtual ICollection<InvCreateInvestment> InvCreateInvestments { get; set; } = new List<InvCreateInvestment>();
}
