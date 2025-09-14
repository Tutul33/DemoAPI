using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sonali.API.Domain.DTOs;
using Sonali.API.Domain.Entities;
using Sonali.API.Domain.Interface;
using Sonali.API.DomainService.Interface;
using Sonali.API.Utilities;

namespace Sonali.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherController : ControllerBase
    {
        private readonly IVoucherRepository _iRepository;
        private readonly IAccountingDomainService _iDataService;
        public VoucherController(IAccountingDomainService iDataService, IVoucherRepository iRepository)
        {
            _iDataService = iDataService;
            _iRepository = iRepository;
        }

        [Authorize]
        [HttpGet]
        [Route("GetVoucherList")]
        public async Task<object?> GetVoucherList([FromQuery] VoucherSearchDTO param)
        {
            object? data = null;
            try
            {
                data = await _iDataService.GetVoucherList(param);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return data;
        }

        [Authorize]
        [HttpGet]
        [Route("GetVoucherDetailsByVoucherNo")]
        public async Task<object?> GetVoucherList([FromQuery] string voucherNo)
        {
            object? data = null;
            try
            {
                data = await _iDataService.GetVoucherDetailsByVoucherNo(voucherNo);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return data;
        }

        [Authorize]
        [HttpGet]
        [Route("GetChartOfAccounts")]
        public async Task<object?> GetChartOfAccounts()
        {
            object? data = null;
            try
            {
                data = await _iDataService.GetChartOfAccounts();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return data;
        }

        [Authorize]
        [HttpPut]
        [Route("UpdateVoucher")]
        public async Task<List<VoucherUpdateDTO>> UpdateVoucher([FromBody] List<VoucherUpdateDTO> voucherUpdateDTO)
        {
            try
            {
                return await _iRepository.UpdateVoucher(voucherUpdateDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Authorize]
        [HttpPut]
        [Route("UpdateVoucherCheckApprove")]
        public async Task<List<CheckAppproveDTO>> UpdateVoucherCheckApprove([FromBody] List<CheckAppproveDTO> voucherUpdateDTO)
        {
            try
            {
                return await _iRepository.UpdateVoucherCheckApprove(voucherUpdateDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Authorize]
        [HttpPost]
        [Route("ReferVoucher")]
        public async Task<VoucherReferralDTO> ReferVoucher([FromBody] VoucherReferralDTO VoucherReferral)
        {
            try
            {
                return await _iRepository.ReferVoucher(VoucherReferral);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Authorize]
        [HttpGet]
        [Route("GetFinanceAndAccountUsers")]
        public async Task<object?> GetFinanceAndAccountUsers()
        {
            object? data = null;
            try
            {
                data = await _iDataService.GetFinanceAndAccountUsers();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return data;
        }

        [Authorize]
        [HttpPost]
        [Route("SaveUpdateVoucher")]
        public async Task<object?> CreateVoucher(VoucherModelDTO dto)
        {
            object? data = null;
            try
            {
                data = await _iRepository.SaveUpdateVoucher(dto);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return data;
        }
    }
}
