using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class WebShariahBoardSpeech
{
    public int DirectorId { get; set; }

    public string? DirectorName { get; set; }

    public string? DirectorNameBangla { get; set; }

    public string? Desination { get; set; }

    public string? DesinationBangla { get; set; }

    public string? Speech { get; set; }

    public string? SpeechBangla { get; set; }

    public string? ImageName { get; set; }

    public int? OrderId { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
