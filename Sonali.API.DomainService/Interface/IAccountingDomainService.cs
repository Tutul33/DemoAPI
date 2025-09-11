using Sonali.API.Domain.DTOs;
using Sonali.API.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.DomainService.Interface
{
    public interface IAccountingDomainService
    {
        Task<object> GetVoucherList(VoucherSearchDTO param);
        Task<object> GetVoucherDetailsByVoucherNo(string voucherNo);
        Task<object> GetChartOfAccounts();
        Task<object> GetFinanceAndAccountUsers();
    }
}
