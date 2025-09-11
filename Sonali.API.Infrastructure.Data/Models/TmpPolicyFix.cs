using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TmpPolicyFix
{
    public int Id { get; set; }

    public int? Orentryid { get; set; }

    public DateTime PostingDate { get; set; }
}
