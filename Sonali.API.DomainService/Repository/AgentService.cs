using Sonali.API.DomainService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.DomainService.Repository
{
    public class AgentService : IAgentService
    {
        private static readonly HashSet<string> _onlineAgents = new();
        public bool IsAnyAgentAvailable() => _onlineAgents.Any();

        public static void SetAgentStatus(string agentId, bool isOnline)
        {
            if (isOnline) _onlineAgents.Add(agentId);
            else _onlineAgents.Remove(agentId);
        }
    }
}
