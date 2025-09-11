using Microsoft.Extensions.Logging;
using Sonali.API.Domain.DTOs;
using Sonali.API.Domain.Entities;
using Sonali.API.DomainService.Base;
using Sonali.API.DomainService.DataService;
using Sonali.API.DomainService.Interface;
using Sonali.API.Infrastructure.DAL.Cache;
using Sonali.API.Utilities;
using Sonali.API.Utilities.Helper;
using StackExchange.Redis;
using System.Data;

namespace Sonali.API.DomainService.Repository
{
    public class AccountingDomainService : IAccountingDomainService
    {
        private readonly IGenericFactoryMSSQL<Voucher> _voucherRepo;
        private readonly IGenericFactoryMSSQL<VoucherDtl> _voucherDtlRepo;
        private readonly IGenericFactoryMSSQL<ChartOfAccounts> _coaRepo;
        private readonly IGenericFactoryMSSQL<FinanceAndBankingUser> _fabUserRepo;
        private readonly ILogger<AccountingDomainService> _logger;
        private readonly IRedisCacheService _redis;
        public AccountingDomainService(IRedisCacheService redis,
            IGenericFactoryMSSQL<Voucher> voucherRepo,
            IGenericFactoryMSSQL<VoucherDtl> voucherDtlRepo,
            IGenericFactoryMSSQL<ChartOfAccounts> coaRepo,
            IGenericFactoryMSSQL<FinanceAndBankingUser> fabUserRepo,
            ILogger<AccountingDomainService> logger)
        {
            _voucherRepo = voucherRepo;
            _voucherDtlRepo = voucherDtlRepo;
            _coaRepo = coaRepo;
            _fabUserRepo = fabUserRepo;
            _logger = logger;
            _redis = redis;
        }

        public async Task<object> GetVoucherList(VoucherSearchDTO param)
        {
            try
            {
                string cacheKey = "";

                if (RedisInfo.IsRedisAlive)
                {
                    cacheKey = CacheKeyHelper.GenerateCacheKey("voucher_list", param);
                    var cachedData = await _redis.GetAsync<List<Voucher>>(cacheKey);
                    if (cachedData != null)
                    {
                        return new { list = cachedData };
                    }
                }
                else
                {
                    _logger.LogWarning("Redis is not available. Proceeding without cache.");
                }


                var parameters = new Dictionary<string, object?>
                {
                    { "PageIndex", param.PageNumber },
                    { "PageSize", param.PageSize },
                    { "Status", param.Status },
                    { "UserIds", param.UserIds },
                    { "VoucherNos", param.VoucherNos },
                    { "FromDate", param.FromDate },
                    { "ToDate", param.ToDate },
                    { "VoucherType", param.VoucherType },
                    { "Search", param.Search }
                };

                var vouchers = await _voucherRepo.ExecuteCommandListAsync(
                    StoredProcedures.sp_GetVoucherApprovalList,
                    parameters,
                    StaticInfos.MsSqlConnectionString
                ) ?? new List<Voucher>();

                if (RedisInfo.IsRedisAlive)
                {
                    await _redis.SetAsync(cacheKey, vouchers, TimeSpan.FromMinutes(10));
                }
                return new { list = vouchers };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching voucher list");
                throw;
            }
        }


        public async Task<object> GetVoucherDetailsByVoucherNo(string voucherNo)
        {
            try
            {
                var parameters = new Dictionary<string, object?>
                {
                    { "VoucherNo", voucherNo }
                };

                var voucherDetails = await _voucherDtlRepo.ExecuteCommandListAsync(
                    StoredProcedures.sp_GetVoucherDetailsByVoucherNo,
                    parameters,
                    StaticInfos.MsSqlConnectionString
                ) ?? new List<VoucherDtl>();

                DataTable dataTable = DataTableHelper.ToDataTable(voucherDetails);
                DataView view = new DataView(dataTable);

                DataTable _voucherData = view.ToTable(
                    true,
                    "Id", "VoucherNo", "CodeAndName", "ActCode", "ActName", "FromActCode", "ToActCode",
                    "DAmount", "CAmount", "Amt", "AccStatement", "Descrp", "ModOfPay", "ChkNo", "ChkDt",
                    "OpeningBalance", "ShopId", "UserId", "EntryDate", "DelDate", "DelUser", "MainCode",
                    "SubGroupCat", "Transfered", "CreateDate", "CheckedBy", "ApprovedBy", "AuthStatus",
                    "CheckedDate", "ApprovedDate"
                    );
                DataTable _referData = view.ToTable(
                    true,
                    "ReferralId", "RefBy", "RefTo", "RefType", "Comments", "ReferDate", "IsActive"
                    );

                // Filter voucherData safely
                var voucherData = _voucherData.AsEnumerable()
                    .Where(row => row.Field<decimal>("Id") != 0);

                var voucherList = voucherData.Any()
                    ? DataTableHelper.DataTableToList<VoucherDtl>(voucherData.CopyToDataTable())
                    : new List<VoucherDtl>();

                // Filter referralData safely
                var referData = _referData.AsEnumerable()
                    .Where(row => row.Field<int>("ReferralId") != 0);

                var referralList = referData.Any()
                    ? DataTableHelper.DataTableToList<VoucherReferralDTO>(referData.CopyToDataTable())
                    : new List<VoucherReferralDTO>();

                return new
                {
                    voucherList,
                    referralList
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error fetching voucher details for {voucherNo}");
                throw;
            }
        }

        public async Task<object> GetChartOfAccounts()
        {
            try
            {
                var coaList = await _coaRepo.ExecuteCommandListAsync(
                    StoredProcedures.sp_GetChartOfAccounts,
                    new Dictionary<string, object?>(),
                    StaticInfos.MsSqlConnectionString
                ) ?? new List<ChartOfAccounts>();

                return new { list = coaList };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching chart of accounts");
                throw;
            }
        }

        public async Task<object> GetFinanceAndAccountUsers()
        {
            try
            {
                var users = await _fabUserRepo.ExecuteCommandListAsync(
                    StoredProcedures.sp_GetFinanceAndAccountUsers,
                    new Dictionary<string, object?>(),
                    StaticInfos.MsSqlConnectionString
                ) ?? new List<FinanceAndBankingUser>();

                return new { list = users };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching finance and banking users");
                throw;
            }
        }


    }
}
