using Sonali.API.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.DomainService.Interface
{
    public interface IChatDomainService
    {
        Task<object> GetMessagesAsync(string user1, string user2, int page = 1, int pageSize = 20);
       
    }
}
