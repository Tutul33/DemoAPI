using Sonali.API.DomainService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.DomainService.Repository
{
    public class KnowledgeBaseService : IKnowledgeBaseService
    {
        private readonly Dictionary<string, string> _kb = new()
        {
            ["Policy_Info"] = "Your policy details are available in the policy section.",
            ["Claim_Status"] = "You can track your claim status online.",
            ["Maturity_Amount"] = "Maturity amount = sum assured + bonuses.",
            ["Loan_Request"] = "Loan can be requested after 3 years of premiums."
        };

        public string? GetAnswer(string intent) => _kb.TryGetValue(intent, out var answer) ? answer : null;
    }
}
