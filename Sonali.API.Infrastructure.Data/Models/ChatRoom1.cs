using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ChatRoom1
{
    public int Id { get; set; }

    public string? ChatText { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? UserCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public string? UserModified { get; set; }

    public string? SendFor { get; set; }

    public int ReadStatus { get; set; }

    public int? GroupId { get; set; }
}
