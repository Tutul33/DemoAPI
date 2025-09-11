using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PayPageObject
{
    public int PageObjectId { get; set; }

    public string? PageTypeName { get; set; }

    public string? PageName { get; set; }

    public string? PagePath { get; set; }

    public string? PageMethodeName { get; set; }
}
