using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class SurveillanceCamara
{
    public int SurveillanceId { get; set; }

    public string? CamaraName { get; set; }

    public string? CamaraUrl { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
