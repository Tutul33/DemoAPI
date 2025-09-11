using Sonali.API.Infrastructure.Data.Models;
using Sonali.API.Utilities.EntityExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Domain.Entities
{
    public class ChatFiles:RowEntity<int>
    {
        public string? FileName { get; set; }

        public string? FileType { get; set; }

        public string? FileUrl { get; set; }

        public DateTime? SentDate { get; set; }

        public int ChatMessageId { get; set; }

        public virtual ChatMessages ChatMessage { get; set; } = null!;
    }

}
