using Sonali.API.Domain.DTOs;

namespace Sonali.API.Domain.Interface
{
    public interface IUserRepository
    {
        Task<List<UserRoleMapDTO>> UpdateUserRoleMap(List<UserRoleMapDTO> userRoleMapDTO);
    }
}
