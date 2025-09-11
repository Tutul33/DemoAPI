using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class WebPartner
{
    public int PartnerId { get; set; }

    public string? PartnerName { get; set; }

    public string? PartnerNameBangla { get; set; }

    public string? PartnerDetail { get; set; }

    public string? PartnerDetailBangla { get; set; }

    public string? PartnerImage { get; set; }

    public string? PartnerWebsite { get; set; }

    public string? PartnerCheck { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
