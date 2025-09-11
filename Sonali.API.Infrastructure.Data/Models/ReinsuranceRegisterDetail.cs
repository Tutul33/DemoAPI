using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ReinsuranceRegisterDetail
{
    public int DocumentId { get; set; }

    public int? RegisterId { get; set; }

    public string? DocumentTitle { get; set; }

    public string? Document { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }
}
