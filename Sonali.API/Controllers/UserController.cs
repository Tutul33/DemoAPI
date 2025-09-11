using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Sonali.API.Domain.DTOs;
using Sonali.API.Domain.Interface;
using Sonali.API.DomainService.Interface;
using Sonali.API.Utilities;
namespace Sonali.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _iRepository;
        private readonly IUserDomainService _iDataService;
        public UserController(IUserRepository userRepository, IUserDomainService dataService)
        {
            _iRepository = userRepository;
            _iDataService = dataService;
        }
        
        [Authorize]
        [HttpGet]
        [Route("GetUserList")]
        public async Task<object?> GetUserList([FromQuery] CommonModel param)
        {
            object? data = null;
            try
            {
               data = await _iDataService.GetUserList(param);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return data;
        }

        [Authorize]
        [HttpGet]
        [Route("GetUsersRoleMap")]
        public async Task<object?> GetUsersRoleMap()
        {
            object? data = null;
            try
            {
                data = await _iDataService.GetUsersRoleMap();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return data;
        }

        [Authorize]
        [HttpPost]
        [Route("UpdateUserRoleMap")]
        public async Task<List<UserRoleMapDTO>> UpdateUserRoleMap([FromBody] List<UserRoleMapDTO> UserRoleMapDTOs)
        {
            try
            {
                return await _iRepository.UpdateUserRoleMap(UserRoleMapDTOs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Authorize]
        [HttpGet]
        [Route("GetFinanceAndAccountUsersRole")]
        public async Task<object?> GetFinanceAndAccountUsersRole()
        {
            object? data = null;
            try
            {
                data = await _iDataService.GetFinanceAndAccountUsersRole();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return data;
        }

    }
}
