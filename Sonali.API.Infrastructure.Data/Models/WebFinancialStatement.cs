using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class WebFinancialStatement
{
    public int Id { get; set; }

    public string? StatementType { get; set; }

    public string? FileName { get; set; }

    public string? Title { get; set; }

    public string? TitleBangla { get; set; }

    public string? CreateBy { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
