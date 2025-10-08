using Sonali.API.Domain.DTOs;
using Sonali.API.DomainService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.DomainService.Repository
{
    public class AIAssistantService:IAIAssistantService
    {
        private readonly IMLIntentService _ml;
        private readonly IKnowledgeBaseService _kb;

        public AIAssistantService(IMLIntentService ml, IKnowledgeBaseService kb)
        {
            _ml = ml;
            _kb = kb;
        }

        public async Task<ChatMessageFileDto> HandleMessageAsync(ChatMessageFileDto message)
        {
            var intent = _ml.PredictIntent(message.Text ?? "");
            var answer = _kb.GetAnswer(intent) ?? "Please wait, a representative will contact you soon.";

            var reply = new ChatMessageFileDto
            {
                Sender = "AI_Assistant",
                Receiver = message.Sender,
                Text = answer,
                SentDate = DateTime.UtcNow
            };

            return reply;
        }
    }
}
