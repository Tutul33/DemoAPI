using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sonali.API.Domain.DTOs;
using Sonali.API.Domain.Entities;
using Sonali.API.Domain.Interface;

namespace Sonali.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _iRepository;
        private readonly IJwtTokenService _jwtTokenService;

        public LoginController(ILoginRepository iRepository, IJwtTokenService jwtTokenService) 
        { 
            _iRepository = iRepository;
            _jwtTokenService = jwtTokenService;
        }
        /// <summary>
        /// 
        [HttpPost]
        [Route("Login")]
        public async Task<object> Login([FromBody] LoginDTO loginDTO)
        {
            try
            {
                var token = _jwtTokenService.GenerateToken(loginDTO.UserName, "Admin");
                var userInfo= await _iRepository.Login(loginDTO);
                return new { token, userInfo };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
