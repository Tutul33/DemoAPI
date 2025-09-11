using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class WebsiteNoticeEvent
{
    public int NoticeSl { get; set; }

    public string? Heading { get; set; }

    public string? HeadingBangla { get; set; }

    public string? Description { get; set; }

    public string? DescriptionBangla { get; set; }

    public DateOnly? EventDate { get; set; }

    public string? EventDateBangla { get; set; }

    public string? EventImage { get; set; }

    public string? PostType { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    public int? VacancyId { get; set; }
}
