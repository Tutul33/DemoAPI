using Sonali.API.Domain.DTOs;
using Sonali.API.Domain.DTOs.DemoDTO;
using Sonali.API.Domain.Entities;
using Sonali.API.DomainService.Base;
using Sonali.API.DomainService.DataService;
using Sonali.API.DomainService.Interface;
using Sonali.API.Infrastructure.DAL.Cache;
using Sonali.API.Utilities.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.DomainService.Repository
{
    public class DemoDomainService : IDemoDomainService
    {
        private readonly IGenericFactoryMSSQL<DemoDTORequest> _demoRepo;
        private readonly IRedisCacheService _redis;
        public DemoDomainService(IGenericFactoryMSSQL<DemoDTORequest> demoRepo, IRedisCacheService redis)
        {
            _demoRepo = demoRepo;
            _redis = redis;
        }

        public async Task<object> GetDemoList()
        {
            try
            {
                // Check if data exists in Redis cache start
                string cacheKey = "";
                if (RedisInfo.IsRedisAlive)
                {
                    cacheKey = "demo_list";
                    var cachedData = await _redis.GetAsync<List<DemoDTORequest>>(cacheKey);

                    if (cachedData != null)
                    {
                        return new { list = cachedData };
                    }
                }
                // Check if data exists in Redis cache end

                var users = await _demoRepo.ExecuteCommandListAsync(
                   StoredProcedures.sp_GetDemoList,
                   new Dictionary<string, object?>(),
                   StaticInfos.MsSqlConnectionString
               ) ?? new List<DemoDTORequest>();

                // Store data in Redis cache for future requests
                if (!RedisInfo.IsRedisAlive)
                    await _redis.SetAsync(cacheKey, users, TimeSpan.FromMinutes(10));

                return new { list = users };
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<object> GetDemoById(int id)
        {
            try
            {
                string cacheKey = "";
                if (RedisInfo.IsRedisAlive)
                {
                    cacheKey = StoredProcedures.sp_GetDemoById + id.ToString();
                    var cachedData = await _redis.GetAsync<List<DemoDTORequest>>(cacheKey);

                    if (cachedData != null)
                    {
                        return PrepareDemoData(cachedData);
                    }
                }
                var parameters = new Dictionary<string, object?>
               {
                   { "id", id }
               };

                var demoData = await _demoRepo.ExecuteCommandListAsync(
                       StoredProcedures.sp_GetDemoById,
                       parameters,
                       StaticInfos.MsSqlConnectionString
                   ) ?? new List<DemoDTORequest>();
                if (RedisInfo.IsRedisAlive)
                {
                    await _redis.SetAsync(cacheKey, demoData, TimeSpan.FromMinutes(10));
                }
                if (demoData.Count == 0)
                {
                    return demoData;
                }
                var result = PrepareDemoData(demoData);

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static object PrepareDemoData(List<DemoDTORequest> demoData)
        {
            try
            {
                // Convert flat list to DataTable
                DataTable dataTable = DataTableHelper.ToDataTable(demoData);
                DataView view = new DataView(dataTable);

                DataTable _demoData = view.ToTable(
                    true,
                    "Id", "Name", "CreateDate", "IsActive"
                );

                DataTable _demoItemData = view.ToTable(
                    true,
                    "DemoItemId", "Id", "DemoItemName", "RefTo", "DemoItemTitle", "DemoItemDescription", "DemoItemActive"
                );

                DataTable _demoItemAttchData = view.ToTable(
                    true,
                    "DAtacchmentId", "DemoItemId", "FileName", "DAttachmentActive"
                );

                // 🔑 Now build hierarchy from existing DataTables
                var result = _demoData.AsEnumerable().Select(demo => new
                {
                    Id = demo["Id"],
                    Name = demo["Name"],
                    CreateDate = demo["CreateDate"],
                    IsActive = demo["IsActive"],

                    DemoItems = _demoItemData.AsEnumerable()
                        .Where(di => di["Id"].ToString() == demo["Id"].ToString())
                        .Select(di => new
                        {
                            Id = di["DemoItemId"],
                            DemoId = demo["Id"],
                            Name = di["DemoItemName"],
                            RefTo = di["RefTo"],
                            Title = di["DemoItemTitle"],
                            Description = di["DemoItemDescription"],
                            IsActive = di["DemoItemActive"],

                            DemoItemFileAttachments = _demoItemAttchData.AsEnumerable()
                                .Where(att => att["DemoItemId"].ToString() == di["DemoItemId"].ToString() && att["DAtacchmentId"].ToString() != "0")
                                .Select(att => new
                                {
                                    Id = att["DAtacchmentId"],
                                    DemoItemId = di["DemoItemId"],
                                    FileName = att["FileName"],
                                    IsActive = att["DAttachmentActive"]
                                }).ToList()
                        }).ToList()
                }).ToList();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
