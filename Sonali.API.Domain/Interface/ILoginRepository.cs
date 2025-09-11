using Sonali.API.Domain.DTOs;

namespace Sonali.API.Domain.Interface
{
    public interface ILoginRepository
    {
        Task<UserDTO> Login(LoginDTO loginDTO);
    }
}
