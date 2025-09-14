using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sonali.API.Domain.DTOs;
using Sonali.API.Domain.Interface;
using Sonali.API.Infrastructure.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Infrastructure.DAL.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        public LoginRepository(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<UserDTO> Login(LoginDTO loginDTO)
        {
            try
            {
                if (loginDTO == null)
                {
                    throw new ArgumentNullException(nameof(loginDTO), "Login data cannot be null");
                }
                string hashToStoreInDatabase = BCrypt.Net.BCrypt.HashPassword(loginDTO.Password, BCrypt.Net.BCrypt.GenerateSalt());
                var user = await _dbContext.AppUsers.AsNoTracking().FirstOrDefaultAsync(u => u.UserName == loginDTO.UserName.ToString().Trim());                
                if (user == null)
                {
                    throw new UnauthorizedAccessException("Invalid username or password");
                }

                if (!BCrypt.Net.BCrypt.Verify(loginDTO.Password, user.Password))
                {
                    throw new UnauthorizedAccessException("Invalid username or password");
                }
                user.Password = loginDTO.Password;

                List<UserRoleMapDTO> userRoles = GetUserRoleMap(user);
                var userDto = _mapper.Map<UserDTO>(user);
                var payRole = _dbContext.PayRoles.FirstOrDefault(u => u.RoleId == user.RoleId);
                userDto.PayRoleName = payRole?.RoleName ?? string.Empty;
                userDto.roleList = _mapper.Map<List<UserRoleMapDTO>>(userRoles);
                //return Task.FromResult(_mapper.Map<UserDTO>(user));
                return userDto;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private List<UserRoleMapDTO> GetUserRoleMap(Data.Models.AppUser user)
        {
            var userRoles = _dbContext.AccUserRoleMaps
                           .Where(urm => urm.UserId == user.Id && urm.IsActive==true)
                           .Join(
                               _dbContext.AccUserRoles,
                               urm => urm.RoleId,   // key from AccUserRoleMaps
                               r => r.Id,          // key from AccUserRoles
                               (urm, r) => new UserRoleMapDTO
                               {
                                   UserRoleMapId = urm.Id,
                                   UserId = urm.UserId,
                                   RoleId = r.Id,
                                   RoleName = r.Name,
                                   IsActive = urm.IsActive
                               }
                           )
                           .ToList();
            return userRoles;
        }
    }
}
