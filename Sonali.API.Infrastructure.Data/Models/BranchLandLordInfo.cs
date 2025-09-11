using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class BranchLandLordInfo
{
    public int SlNo { get; set; }

    public int? BranchId { get; set; }

    public string? LandLordName { get; set; }

    public string? LandLordMobile { get; set; }

    public string? LandLordBankName { get; set; }

    public string? LandLordBankAccNo { get; set; }

    public string? LandLordContractDoc { get; set; }

    public string? LandLordNic { get; set; }

    public string? LandLordNicdoc { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }
}
