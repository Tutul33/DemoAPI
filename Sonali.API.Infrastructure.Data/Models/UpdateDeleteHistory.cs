using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class UpdateDeleteHistory
{
    public int Id { get; set; }

    public int UdtypeId { get; set; }

    public string? Comments { get; set; }

    public int? RefNo { get; set; }

    public string CreateBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string? FileName { get; set; }
}
