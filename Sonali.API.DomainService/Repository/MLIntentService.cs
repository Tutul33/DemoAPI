using Sonali.API.DomainService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.DomainService.Repository
{
    public class MLIntentService : IMLIntentService
    {
        public string PredictIntent(string text)
        {
            text = text.ToLower();
            if (text.Contains("policy")) return "Policy_Info";
            if (text.Contains("claim")) return "Claim_Status";
            if (text.Contains("maturity")) return "Maturity_Amount";
            if (text.Contains("loan")) return "Loan_Request";
            return "Unknown";
        }
    }
}
