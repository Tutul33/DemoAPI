using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Assessment
{
    public int AssessmentId { get; set; }

    public int? TrainingId { get; set; }

    public DateOnly? AssessmentDate { get; set; }

    public int? UserId { get; set; }

    public double? Result { get; set; }

    public string? CreateBy { get; set; }

    public string? UserType { get; set; }
}
