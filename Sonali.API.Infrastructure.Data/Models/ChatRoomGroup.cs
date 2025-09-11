using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ChatRoomGroup
{
    public int Id { get; set; }

    public string? GroupName { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
