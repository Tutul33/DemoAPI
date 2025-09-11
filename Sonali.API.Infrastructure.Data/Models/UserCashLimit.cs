using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class UserCashLimit
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public int CashLimit { get; set; }

    public string CreateBy { get; set; } = null!;

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
