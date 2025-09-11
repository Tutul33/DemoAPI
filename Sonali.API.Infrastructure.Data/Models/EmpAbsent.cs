using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class EmpAbsent
{
    public int Sl { get; set; }

    public int EmpId { get; set; }

    public long? Rfid { get; set; }

    public DateOnly? AbsentDate { get; set; }
}
