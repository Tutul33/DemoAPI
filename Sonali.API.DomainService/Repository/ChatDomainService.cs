using Microsoft.Extensions.Logging;
using Sonali.API.Domain.DTOs;
using Sonali.API.Domain.Entities;
using Sonali.API.DomainService.Base;
using Sonali.API.DomainService.DataService;
using Sonali.API.DomainService.Interface;
using Sonali.API.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Sonali.API.DomainService.Repository
{
    public class ChatDomainService : IChatDomainService
    {
        private readonly IGenericFactoryMSSQL<ChatMessageRequestDto> _chatRepo;
        private readonly ILogger<ChatDomainService> _logger;

        public ChatDomainService(
           IGenericFactoryMSSQL<ChatMessageRequestDto> chatRepo,
           ILogger<ChatDomainService> logger)
        {
            _chatRepo = chatRepo;
            _logger = logger;
        }

        public async Task<object> GetMessagesAsync(string Sender, string Receiver, int page = 1, int pageSize = 20)
        {
            try
            {
                var parameters = new Dictionary<string, object?>
                {
                    { "Sender", Sender },
                    { "Receiver", Receiver },
                    { "PageIndex", page },
                    { "PageSize", pageSize }
                };

                var rawList = await _chatRepo.ExecuteCommandListAsync(
                    StoredProcedures.sp_GetChatMessageList,
                    parameters,
                    StaticInfos.MsSqlConnectionString
                ) ?? new List<ChatMessageRequestDto>();

                var messageList = rawList
                .GroupBy(r => r.Id)
                .Select(g =>
                {
                    var first = g.First();

                    var files = g
                        .Where(x => x.FileId > 0)               // filter out null file rows
                        .Select(x => new ChatFileDto
                        {
                            Id = x.FileId,                    // safe because of HasValue
                            FileName = x.FileName,
                            FileType = x.FileType,
                            FileUrl = x.FileUrl,
                            ChatMessageId = first.Id
                        })
                        .ToList();

                    return new ChatMessageFileDto
                    {
                        Id = first.Id,
                        Sender = first.Sender,
                        Receiver = first.Receiver,
                        Text = first.Text,
                        SentDate = first.SentDate,
                        IsRead = first.IsRead,
                        Files = files
                    };
                })
                .ToList();//.OrderByDescending(x=>x.SentDate);

                return new
                {
                    list = messageList
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching user list");
                throw;
            }
        }

    }
}
