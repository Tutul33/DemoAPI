using Sonali.API.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.DomainService.Interface
{
    public interface IUserDomainService
    {
        Task<object> GetUserList(CommonModel param);
        Task<object> GetUsersRoleMap();
        Task<object> GetFinanceAndAccountUsersRole();
    }
}
