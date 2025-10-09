using Sonali.API.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.DomainService.Interface
{
    public interface IAIAssistantService
    {
        Task<BotMessageDto> HandleMessageAsync(BotMessageDto message);
    }
}
