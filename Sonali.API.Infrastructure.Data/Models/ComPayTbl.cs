using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ComPayTbl
{
    public int Id { get; set; }

    public string? Pol { get; set; }

    public string? Pr { get; set; }

    public string? Fa { get; set; }

    public string? Um { get; set; }

    public string? Bm { get; set; }

    public string? Bc { get; set; }

    public string? Dc { get; set; }

    public string? Rc { get; set; }

    public string? Dvc { get; set; }

    public decimal? Unpaid { get; set; }

    public decimal? TotalPaid { get; set; }

    public DateOnly? ComDate { get; set; }

    public string? UserName { get; set; }
}
