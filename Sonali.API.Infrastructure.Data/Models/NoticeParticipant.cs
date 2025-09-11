using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class NoticeParticipant
{
    public int Sl { get; set; }

    public int? NoticeId { get; set; }

    public int? ParticipantId { get; set; }

    public string? EmpType { get; set; }

    public string? IsInterested { get; set; }

    public DateTime? UpdateDate { get; set; }
}
