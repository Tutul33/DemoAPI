using Microsoft.Extensions.Logging;
using Moq;
using Sonali.API.Domain.DTOs;
using Sonali.API.Domain.Entities;
using Sonali.API.DomainService.DataService;
using Sonali.API.DomainService.Repository;
using Sonali.API.Infrastructure.DAL.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sonali.API.Tests.UnitTests.DomainService
{
    public class AccountingDomainServiceTests
    {
        private readonly AccountingDomainService _service;
        private readonly Mock<IGenericFactoryMSSQL<Voucher>> _voucherRepoMock;

        public AccountingDomainServiceTests()
        {
            _voucherRepoMock = new Mock<IGenericFactoryMSSQL<Voucher>>();
            var voucherDtlRepoMock = new Mock<IGenericFactoryMSSQL<VoucherDtl>>();
            var coaRepoMock = new Mock<IGenericFactoryMSSQL<ChartOfAccounts>>();
            var fabUserRepoMock = new Mock<IGenericFactoryMSSQL<FinanceAndBankingUser>>();
            var loggerMock = new Mock<ILogger<AccountingDomainService>>();
            var redisMock = new Mock<IRedisCacheService>();
            _service = new AccountingDomainService(
                redisMock.Object,
                    _voucherRepoMock.Object,
                    voucherDtlRepoMock.Object,
                    coaRepoMock.Object,
                    fabUserRepoMock.Object,
                    loggerMock.Object
                );
        }

        [Fact]
        public async Task GetVoucherList_ShouldReturnVouchers()
        {
            try
            {
                // Arrange Data
                _voucherRepoMock
                    .Setup(x => x.ExecuteCommandListAsync(It.IsAny<string>(), It.IsAny<Dictionary<string, object?>>(), It.IsAny<string>()))
                    .ReturnsAsync(new List<Voucher> { new Voucher { VoucherNo = "V001" } });

                // Act
                var result = await _service.GetVoucherList(new VoucherSearchDTO());

                // Assert
                Assert.NotNull(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
