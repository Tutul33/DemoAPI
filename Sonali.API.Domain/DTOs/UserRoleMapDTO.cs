using Sonali.API.Domain.Entities;

namespace Sonali.API.Domain.DTOs
{
    public class UserRoleMapDTO:UserRoleMap
    {
        public string UserName { get; set; } = "";
        public int EmpId { get; set; }
        public string EmpName { get; set; } = "";
        public string RoleName { get; set; }= "";
        public int UserRoleMapId { get; set; }
    }
}
