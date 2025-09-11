using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class SslSm
{
    public int Id { get; set; }

    public string? Refid { get; set; }

    public DateTime? Smsdate { get; set; }

    public string? Mobno { get; set; }

    public string? Smsstatus { get; set; }

    public string? Msg { get; set; }
}
