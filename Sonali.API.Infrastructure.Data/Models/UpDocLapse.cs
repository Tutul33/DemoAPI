using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class UpDocLapse
{
    public int Sl { get; set; }

    public long? Fprid { get; set; }

    public DateOnly? Npdd { get; set; }

    public int ReqFlag { get; set; }

    public string? DghdocName { get; set; }

    public string? MedDocName { get; set; }

    public int ApprovalFlag { get; set; }

    public DateTime? SysDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? Comments { get; set; }
}
