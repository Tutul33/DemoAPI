using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class LoanComment
{
    public int Id { get; set; }

    public int? LoanId { get; set; }

    public string? Comments { get; set; }
}
