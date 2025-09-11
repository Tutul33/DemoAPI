using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sonali.API.Domain.DTOs;
using Sonali.API.Domain.Entities;
using Sonali.API.Domain.Interface;
using Sonali.API.Infrastructure.Data.Data;
using Sonali.API.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sonali.API.Infrastructure.DAL.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public UserRepository(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<UserRoleMapDTO>> UpdateUserRoleMap(List<UserRoleMapDTO> userRoleMapDTO)
        {
            try
            {
                if (userRoleMapDTO == null)
                {
                    throw new ArgumentNullException(nameof(userRoleMapDTO), "Data cannot be empty.");
                }

                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<UserRoleMapDTO, AccUserRoleMap>()
                  .BeforeMap((s, d) =>
                  {
                      if (s.Tag == EntityState.Added)
                      {
                          if (s.IsActive == null)
                              s.IsActive = false;
                      }
                  })
                  .AfterMap((s, d) =>
                  {

                      switch (s.Tag)
                      {
                          case EntityState.Added:
                              _dbContext.AccUserRoleMaps.Add(d);
                              s.Tag = 0;
                              break;
                          case EntityState.Modified:
                              d.Id = s.UserRoleMapId;
                              _dbContext.AccUserRoleMaps.Update(d);
                              s.Tag = 0;
                              break;
                          case EntityState.Deleted:

                              break;
                      }
                  })).CreateMapper();
                userRoleMapDTO.Select((e) => mapper.Map<AccUserRoleMap>(e)).ToList();

                await _dbContext.SaveChangesAsync();

                return userRoleMapDTO;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //public async Task<List<UserRoleMapDTO>> UpdateUserRoleMap(List<UserRoleMapDTO> userRoleMapDTO)
        //{
        //    if (userRoleMapDTO == null)
        //        throw new ArgumentNullException(nameof(userRoleMapDTO), "Data cannot be empty.");

        //    // Step 1: Load all existing entities in one query to avoid multiple FindAsync
        //    var idsToUpdateOrDelete = userRoleMapDTO
        //        .Where(d => d.Tag == EntityState.Modified || d.Tag == EntityState.Deleted)
        //        .Select(d => d.UserRoleMapId)
        //        .ToList();

        //    var existingEntities = await _dbContext.AccUserRoleMaps.AsNoTracking()
        //        .Where(x => idsToUpdateOrDelete.Contains(x.Id))
        //        .ToDictionaryAsync(x => x.Id); // track by Id

        //    foreach (var dto in userRoleMapDTO)
        //    {
        //        switch (dto.Tag)
        //        {
        //            case EntityState.Added:
        //                if (dto.IsActive == null) dto.IsActive = false;
        //                var newEntity = _mapper.Map<AccUserRoleMap>(dto);
        //                _dbContext.AccUserRoleMaps.Add(newEntity);
        //                dto.Tag = 0;
        //                break;

        //            case EntityState.Modified:
        //                if (existingEntities.TryGetValue(dto.UserRoleMapId, out var trackedEntity))
        //                {
        //                    // Map DTO onto tracked entity
        //                    _mapper.Map(dto, trackedEntity);
        //                    // EF already tracks it
        //                }
        //                else
        //                {
        //                    // Optional: attach if not found (rare)
        //                    var attachEntity = _mapper.Map<AccUserRoleMap>(dto);
        //                    _dbContext.AccUserRoleMaps.Attach(attachEntity);
        //                    _dbContext.Entry(attachEntity).State = EntityState.Modified;
        //                }
        //                dto.Tag = 0;
        //                break;

        //            case EntityState.Deleted:
        //                if (existingEntities.TryGetValue(dto.UserRoleMapId, out var entityToDelete))
        //                {
        //                    _dbContext.AccUserRoleMaps.Remove(entityToDelete);
        //                }
        //                dto.Tag = 0;
        //                break;
        //        }
        //    }

        //    await _dbContext.SaveChangesAsync();
        //    return userRoleMapDTO;
        //}



    }

}
