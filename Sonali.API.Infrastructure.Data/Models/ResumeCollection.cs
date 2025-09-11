using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ResumeCollection
{
    public int Id { get; set; }

    public string? ApplicantName { get; set; }

    public string? ApplicantAddress { get; set; }

    public string? PhoneNo { get; set; }

    public string? Email { get; set; }

    public string? UploadResume { get; set; }

    public string? ApplicantLevel { get; set; }

    public DateTime? ResumeReceivingDate { get; set; }

    public int? VacancyId { get; set; }
}
