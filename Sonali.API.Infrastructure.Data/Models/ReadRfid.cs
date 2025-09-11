using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ReadRfid
{
    public long Rfid { get; set; }

    public DateTime? CreateDate { get; set; }
}
