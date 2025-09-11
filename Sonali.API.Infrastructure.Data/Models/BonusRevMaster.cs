using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class BonusRevMaster
{
    public decimal RevId { get; set; }

    public string? RevName { get; set; }

    public string? Descrip { get; set; }

    public int? ProductId { get; set; }

    public string? UserName { get; set; }

    public DateOnly? CreateDate { get; set; }
}
