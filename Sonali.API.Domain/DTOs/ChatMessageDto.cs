using Sonali.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Domain.DTOs
{
    public class ChatMessageFileDto : ChatMessages
    {
        public List<ChatFileDto>? Files { get; set; } = new List<ChatFileDto>();
    }
    public class ChatMessageDto : ChatMessages
    {
    }

    public class ChatMessageRequestDto
    {
        public int Id { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Text { get; set; }
        public DateTime SentDate { get; set; }
        public bool IsRead { get; set; }
        public int FileId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FileUrl { get; set; }
        public List<ChatFiles>? Files { get; set; } = new List<ChatFiles>();
    }

}
