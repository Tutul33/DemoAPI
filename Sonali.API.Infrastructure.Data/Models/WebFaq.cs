using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class WebFaq
{
    public int Faqid { get; set; }

    public string? Question { get; set; }

    public string? QuestionBangla { get; set; }

    public string? Answer { get; set; }

    public string? AnswerBangla { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
