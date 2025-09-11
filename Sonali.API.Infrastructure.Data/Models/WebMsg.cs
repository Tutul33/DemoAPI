using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class WebMsg
{
    public int MessageId { get; set; }

    public string? WriterName { get; set; }

    public string? WriterNameBangla { get; set; }

    public string? Designation { get; set; }

    public string? DesignationBangla { get; set; }

    public string? Message { get; set; }

    public string? MessageBangla { get; set; }

    public string? ImageName { get; set; }

    public int? OrderId { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
