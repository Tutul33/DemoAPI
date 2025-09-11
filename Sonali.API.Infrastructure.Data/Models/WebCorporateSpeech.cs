using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class WebCorporateSpeech
{
    public int CorporateSpeechId { get; set; }

    public string? CorporateSpeechEmpType { get; set; }

    public int? CorporateSpeechUserId { get; set; }

    public string? CorporateSpeechText { get; set; }

    public string? CorporateSpeechTextBangla { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
