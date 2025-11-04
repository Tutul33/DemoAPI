using Microsoft.Extensions.Logging;
using Sonali.API.Domain.DTOs;
using Sonali.API.Domain.Entities;
using Sonali.API.DomainService.Base;
using Sonali.API.DomainService.DataService;
using Sonali.API.DomainService.Interface;
using Sonali.API.Utilities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sonali.API.DomainService.Repository
{
    public class UserDomainService : IUserDomainService
    {
        private readonly IGenericFactoryMSSQL<User> _userRepo;
        private readonly IGenericFactoryMSSQL<UserRoleMapDTO> _userRoleMapRepo;
        private readonly IGenericFactoryMSSQL<UserRoleDTO> _userRoleRepo;
        private readonly ILogger<UserDomainService> _logger;

        public UserDomainService(
           IGenericFactoryMSSQL<User> userRepo,
           IGenericFactoryMSSQL<UserRoleMapDTO> userRoleMapRepo,
           IGenericFactoryMSSQL<UserRoleDTO> userRoleRepo,
           ILogger<UserDomainService> logger)
        {
            _userRepo = userRepo;
            _userRoleMapRepo = userRoleMapRepo;
            _userRoleRepo = userRoleRepo;
            _logger = logger;
        }

        public async Task<object> GetUserList(CommonModel param)
        {
            try
            {
                var parameters = new Dictionary<string, object?>
                {
                    { "PageIndex", param.PageNumber },
                    { "PageSize", param.PageSize }
                };

                var users = await _userRepo.ExecuteCommandListAsync(StoredProcedures.sp_GetUserList,parameters,StaticInfos.MsSqlConnectionString) ?? new List<User>();

                return new { list = users };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching user list");
                throw;
            }
        }

        public async Task<object> GetUsersRoleMap()
        {
            try
            {
                var users = await _userRoleMapRepo.ExecuteCommandListAsync(StoredProcedures.sp_GetUsersRoleMap,new Dictionary<string, object?>(),StaticInfos.MsSqlConnectionString) ?? new List<UserRoleMapDTO>();

                return new { list = users };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching finance and banking users role map");
                throw;
            }
        }
        public async Task<object> GetFinanceAndAccountUsersRole()
        {
            try
            {
                var users = await _userRoleRepo.ExecuteCommandListAsync(StoredProcedures.sp_GetFinanceAndAccountUsersRole,new Dictionary<string, object?>(),StaticInfos.MsSqlConnectionString) ?? new List<UserRoleDTO>();

                return new { list = users };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching finance and banking users role map");
                throw;
            }
        }
    }
}
