using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class InvCreateInvestment
{
    public int Id { get; set; }

    public int Type { get; set; }

    public string Name { get; set; } = null!;

    public string Unit { get; set; } = null!;

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<InvBuy> InvBuys { get; set; } = new List<InvBuy>();

    public virtual ICollection<InvSell> InvSells { get; set; } = new List<InvSell>();

    public virtual InvTypeEntry TypeNavigation { get; set; } = null!;
}
