using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Traning
{
    public int TraningId { get; set; }

    public string? TraningName { get; set; }

    public DateOnly? Deadline { get; set; }

    public string? TraningContent { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
