using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sonali.API.Domain.DTOs;
using Sonali.API.Domain.Entities;
using Sonali.API.Domain.Interface;
using Sonali.API.Infrastructure.Data.Data;
using Sonali.API.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Infrastructure.DAL.Repository
{
    public class VoucherRepository : IVoucherRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public VoucherRepository(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<VoucherReferralDTO> ReferVoucher(VoucherReferralDTO referralDTO)
        {
            try
            {
                if (referralDTO == null)
                {
                    throw new ArgumentNullException(nameof(referralDTO), "Referral data cannot be null");
                }
                var referralEntity = referralDTO as VoucherReferral;// Please explain that
                var referral = _mapper.Map<AccVoucherReferral>(referralEntity);
                referral.IsActive = true;
                referral.ReferDate = DateTime.Now;
                _dbContext.AccVoucherReferrals.Add(referral);

                await setOtherReferralInActive(referralDTO.VoucherNo);
                await _dbContext.SaveChangesAsync();
                return referralDTO;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task setOtherReferralInActive(string VoucherNo)
        {
            try
            {
                var extingReferList = await _dbContext.AccVoucherReferrals.AsNoTracking().Where((item) => item.VoucherNo == VoucherNo).ToListAsync();
                foreach (var item in extingReferList)
                {
                    item.IsActive = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<VoucherUpdateDTO>> UpdateVoucher(List<VoucherUpdateDTO> voucherDTO)
        {
			try
			{
                if (voucherDTO == null)
                {
                    throw new ArgumentNullException(nameof(voucherDTO), "Voucher data cannot be null");
                }
                if(voucherDTO.Count == 0)
                {
                    throw new ArgumentException("Voucher data cannot be empty", nameof(voucherDTO));
                }
                if (voucherDTO[0].UpdateType == "referral-pending")
                {
                    if (voucherDTO.Any(v => v.Damount <= 0 && v.Camount <= 0))
                    {
                        throw new ArgumentException("Either DAmount or CAmount must be greater than zero", nameof(voucherDTO));
                    }
                    await UpdateReferral(voucherDTO);
                    if (!string.IsNullOrEmpty(voucherDTO[0].VoucherNo))
                    { 
                        await setOtherReferralInActive(voucherDTO[0].VoucherNo); 
                    }
                }
                

                await _dbContext.SaveChangesAsync();
                return voucherDTO;
            }
			catch (Exception)
			{

				throw;
			}
        }
        public async Task<List<CheckAppproveDTO>> UpdateVoucherCheckApprove(List<CheckAppproveDTO> voucherDTO)
        {
			try
			{
                if (voucherDTO == null)
                {
                    throw new ArgumentNullException(nameof(voucherDTO), "Voucher data cannot be null");
                }
                if(voucherDTO.Count == 0)
                {
                    throw new ArgumentException("Voucher data cannot be empty", nameof(voucherDTO));
                }
                
                    await UpdateCheckOrApproval(voucherDTO);
                

                await _dbContext.SaveChangesAsync();
                return voucherDTO;
            }
			catch (Exception)
			{

				throw;
			}
        }

        private async Task UpdateCheckOrApproval(List<CheckAppproveDTO> voucherDTO)
        {
            foreach (var voucher in voucherDTO)
            {
                var existingVoucher = await _dbContext.Accgl2025s.AsNoTracking().FirstOrDefaultAsync((item) => item.Id == voucher.Id);
                if (existingVoucher != null)
                {
                    if (!string.IsNullOrEmpty(voucher.ApprovedBy))
                    {
                        existingVoucher.ApprovedBy = voucher.ApprovedBy;
                        existingVoucher.ApprovedDate = DateTime.Now;
                    }

                    if (!string.IsNullOrEmpty(voucher.CheckedBy))
                    {
                        existingVoucher.CheckedBy = voucher.CheckedBy;
                        existingVoucher.CheckedDate = DateTime.Now;
                    }
                }
            }
        }
        private async Task UpdateReferral(List<VoucherUpdateDTO> voucherDTO)
        {
            try
            {
                foreach (var voucher in voucherDTO)
                {
                    if (voucher.Tag == EntityState.Added)
                    {
                        var newEntity = _mapper.Map<Accgl2025>(voucher);
                        newEntity.Id = 0;  
                        newEntity.CreateDate= DateTime.Now;
                        _dbContext.Accgl2025s.Add(newEntity);
                    }
                    else if (voucher.Tag == EntityState.Modified)
                    {
                        var existingEntity = await _dbContext.Accgl2025s.AsNoTracking().FirstOrDefaultAsync(e => e.Id == voucher.Id);
                        if (existingEntity == null)
                        {
                            throw new KeyNotFoundException($"Voucher with ID {voucher.Id} not found.");
                        }

                        _mapper.Map(voucher, existingEntity);
                    }
                    else if (voucher.Tag == EntityState.Deleted)
                    {
                        var existingEntity = await _dbContext.Accgl2025s.AsNoTracking().FirstOrDefaultAsync(e => e.Id == voucher.Id);
                        if (existingEntity == null)
                        {
                            throw new KeyNotFoundException($"Voucher with ID {voucher.Id} not found.");
                        }
                        voucher.DelDate= DateTime.Now;
                        _mapper.Map(voucher, existingEntity);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<VoucherModelDTO> SaveUpdateVoucher(VoucherModelDTO dto)
        {
            // 1️⃣ Financial year validation
            var fy = await _dbContext.FinancialYears
                .FirstOrDefaultAsync(f => dto.Date >= f.StartDate && dto.Date <= f.EndDate);

            if (fy == null)
                throw new ArgumentException("Voucher date is outside financial year!");

            // 2️⃣ Lock entry validation
            var lockEntry = await _dbContext.LockEntries
                .FirstOrDefaultAsync(l => Convert.ToDateTime(dto.Date) >= l.LockStart && Convert.ToDateTime(dto.Date) <= l.LockEnd);

            if (lockEntry != null)
                throw new ArgumentException("Voucher date is locked for entry!");

            VoucherHeader voucher;

            if (dto.VoucherId<0) // New voucher
            {
                voucher = _mapper.Map<VoucherHeader>(dto);
                voucher.CreatedBy = dto.CreatedBy;
                voucher.CreatedAt = DateTime.UtcNow;

                // ensure all detail rows are treated as new
                foreach (var entry in voucher.VoucherEntries)
                {
                    _dbContext.Entry(entry).State = EntityState.Added;
                }

                _dbContext.VoucherHeaders.Add(voucher);
            }
            else 
            {
                voucher = await _dbContext.VoucherHeaders
                    .Include(v => v.VoucherEntries)
                    .FirstOrDefaultAsync(v => v.VoucherId == dto.VoucherId);

                if (voucher == null)
                    throw new KeyNotFoundException("Voucher not found!");

                _mapper.Map(dto, voucher);

                voucher.ModifiedBy = dto.ModifiedBy;
                voucher.ModifiedAt = DateTime.UtcNow;

                // process detail lines based on their EntityState
                foreach (var detail in dto.VoucherEntries)
                {
                    if (detail.Tag == EntityState.Added)
                    {
                        var entry = _mapper.Map<VoucherEntry>(detail);
                        voucher.VoucherEntries.Add(entry);
                    }
                    else if (detail.Tag == EntityState.Modified)
                    {
                        var existingEntry = voucher.VoucherEntries.FirstOrDefault(e => e.EntryId == detail.EntryId);
                        if (existingEntry != null)
                        {
                            _mapper.Map(detail, existingEntry);
                            _dbContext.Entry(existingEntry).State = EntityState.Modified;
                        }
                    }
                    else if (detail.Tag == EntityState.Deleted)
                    {
                        var existingEntry = voucher.VoucherEntries.FirstOrDefault(e => e.EntryId == detail.EntryId);
                        if (existingEntry != null)
                        {
                            _dbContext.VoucherEntries.Remove(existingEntry);
                        }
                    }
                }

                _dbContext.Entry(voucher).State = EntityState.Modified;
            }
            
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<VoucherModelDTO>(voucher);
        }



    }
}
