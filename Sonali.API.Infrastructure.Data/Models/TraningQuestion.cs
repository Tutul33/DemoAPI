using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TraningQuestion
{
    public int QuestionId { get; set; }

    public string? QuestionTitle { get; set; }

    public string? Answer1 { get; set; }

    public string? Answer2 { get; set; }

    public string? Answer3 { get; set; }

    public string? Answer4 { get; set; }

    public int? CorrectAnswer { get; set; }

    public int? TraningId { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
