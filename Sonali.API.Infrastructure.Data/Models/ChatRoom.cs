using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ChatRoom
{
    public int Id { get; set; }

    public string? GroupName { get; set; }

    public string? ChatText { get; set; }

    public string? ReadBy { get; set; }

    public int? UserCount { get; set; }
}
