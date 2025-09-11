using Sonali.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Domain.DTOs
{
    public class UserDTO:User
    {
        public string? PayRoleName { get; set; }
        public List<UserRoleMapDTO>? roleList { get; set; } = new List<UserRoleMapDTO>();
    }
}
