using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ChatMessage
{
    public int Id { get; set; }

    public string? Sender { get; set; }

    public string? Receiver { get; set; }

    public string? Text { get; set; }

    public DateTime? SentDate { get; set; }

    public bool? IsRead { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<ChatFile> ChatFiles { get; set; } = new List<ChatFile>();
}
