using Sonali.API.Domain.DTOs;

namespace Sonali.API.Domain.Interface
{
    public interface IVoucherRepository
    {
        Task<List<VoucherUpdateDTO>> UpdateVoucher(List<VoucherUpdateDTO> voucherUpdateDTO);
        Task<List<CheckAppproveDTO>> UpdateVoucherCheckApprove(List<CheckAppproveDTO> voucherUpdateDTO);
        Task<VoucherReferralDTO> ReferVoucher(VoucherReferralDTO voucherUpdateDTO);
        Task<VoucherModelDTO> SaveUpdateVoucher(VoucherModelDTO voucherModelDTO);
    }
}
