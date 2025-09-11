using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Gtlisetup
{
    public int GtliId { get; set; }

    public int GroupCategory { get; set; }

    public int? GroupSubCategory { get; set; }

    public int TransferStatus { get; set; }

    public DateOnly? CommencementDate { get; set; }

    public string? GroupType { get; set; }

    public string? PremiumRateType { get; set; }

    public string? GtliContract { get; set; }

    public string? OrganisationName { get; set; }

    public string? OrganisationAddress { get; set; }

    public string? RegNo { get; set; }

    public int? AgentId { get; set; }

    public int? BranchId { get; set; }

    public DateOnly? SigningDate { get; set; }

    public int Flag { get; set; }

    public int CsdelStatus { get; set; }

    public string? CsdeliveredBy { get; set; }

    public DateOnly? CsdeliveryDate { get; set; }

    public int? SerialNumber { get; set; }

    public int? IniEmpNo { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
