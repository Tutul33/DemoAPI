using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class ChatFile
{
    public int Id { get; set; }

    public string? FileName { get; set; }

    public string? FileType { get; set; }

    public string? FileUrl { get; set; }

    public DateTime? SentDate { get; set; }

    public int ChatMessageId { get; set; }

    public virtual ChatMessage ChatMessage { get; set; } = null!;
}
