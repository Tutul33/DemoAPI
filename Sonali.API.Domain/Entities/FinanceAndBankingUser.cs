using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Domain.Entities
{
    public class FinanceAndBankingUser
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public int EmpId { get; set; }
        public string EmpName { get; set; } = string.Empty;
    }
}
