using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class NoticeBoardSetup
{
    public int NoticeId { get; set; }

    public DateOnly? EventsDate { get; set; }

    public string? EventsTime { get; set; }

    public string? Venue { get; set; }

    public string? NoticeTitle { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
