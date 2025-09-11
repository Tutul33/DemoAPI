using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class WebFormDownload
{
    public int FormId { get; set; }

    public string? FormName { get; set; }

    public string? FormNameBangla { get; set; }

    public string? FormDescription { get; set; }

    public string? FormDescriptionBangla { get; set; }

    public string? HyperlinkName { get; set; }

    public string? HyperlinkNameBangla { get; set; }

    public string? PageHyperlink { get; set; }

    public string FormDownload { get; set; } = null!;

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
