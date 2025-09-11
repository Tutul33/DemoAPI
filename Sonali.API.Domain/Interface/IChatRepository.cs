using Microsoft.AspNetCore.Http;
using Sonali.API.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Domain.Interface
{
    public interface IChatRepository
    {
        Task<ChatMessageFileDto> SaveMessageAsync(ChatMessageFileDto message, List<IFormFile> files);
        Task<bool> DeleteMessageAsync(int id);
        Task<bool> DeleteFileAsync(int id);
        Task<List<ChatMessageDto>> GetMessagesAsync(string user1, string user2, int page, int pageSize);
        Task<ChatMessageDto> UpdateMessageAsync(ChatMessageDto message);
    }
}
