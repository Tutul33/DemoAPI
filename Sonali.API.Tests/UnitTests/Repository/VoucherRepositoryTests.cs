using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sonali.API.Domain.DTOs;
using Sonali.API.Infrastructure.DAL.Repository;
using Sonali.API.Infrastructure.Data.Data;
using Sonali.API.Infrastructure.Data.Models;
using Sonali.API.Tests.DbFactory;
using Xunit;
namespace Sonali.API.Tests.UnitTests.Repository
{
    public class VoucherRepositoryTests
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly VoucherRepository _repository;

        public VoucherRepositoryTests()
        {
            try
            {
                var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase("TestDb_" + Guid.NewGuid()) // unique DB per test
                .Options;

                _dbContext = new TestAppDbContext(options);

                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<VoucherUpdateDTO, Accgl2025>().ReverseMap();
                });
                _mapper = config.CreateMapper();

                _repository = new VoucherRepository(_dbContext, _mapper);

                
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Fact]
        public async Task UpdateVoucher_ShouldAddNewVoucher()
        {
            try
            {
                var voucherList = new List<VoucherUpdateDTO>
                {
                    new VoucherUpdateDTO
                    {
                        Id = 1m,  // explicitly set because decimal PK
                        Tag = EntityState.Added,
                        Damount = 100,
                        Camount = 100,
                        UpdateType = "referral-pending",
                        ActCode = "111120",
                        FromActCode = "211811",
                        ToActCode = "111120",
                        VoucherNo = "250818188316741239",
                    }
                };

                var result = await _repository.UpdateVoucher(voucherList);

                Assert.Single(result);
                Assert.Single(_dbContext.Accgl2025s);
                Assert.Equal(100, _dbContext.Accgl2025s.First().Damount);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Fact]
        public void Should_Insert_ReferVoucher()
        {
            try
            {
                // Arrange
                var voucher = new Accgl2025
                {
                    Id = 2m,
                    VoucherNo = "V123",
                    Damount = 500,
                    ActCode = "111120",
                    FromActCode = "211811",
                    ToActCode = "111120"
                };

                // Act
                _dbContext.Accgl2025s.Add(voucher);
                _dbContext.SaveChanges();

                // Assert
                var savedVoucher = _dbContext.Accgl2025s.FirstOrDefault(v => v.Id == 2m);
                Assert.NotNull(savedVoucher);
                Assert.Equal("V123", savedVoucher.VoucherNo);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Fact]
        public async Task UpdateVoucherCheckApprove_ShouldUpdateApprovedAndCheckedBy()
        {
            try
            {
                // Seed initial data
                _dbContext.Accgl2025s.Add(new Accgl2025
                {
                    Id = 1m,
                    VoucherNo = "V001",
                    Damount = 100,
                    Camount = 50,
                    ActCode = "111120",
                    FromActCode = "211811",
                    ToActCode = "111120"
                });
                _dbContext.SaveChanges();

                // Arrange
                var dtoList = new List<CheckAppproveDTO>
                {
                    new CheckAppproveDTO
                    {
                        Id = 1,
                        ApprovedBy = "ManagerA",
                        CheckedBy = "AuditorB"
                    }
                };

                // Act
                var result = await _repository.UpdateVoucherCheckApprove(dtoList);

                // Assert
                Assert.Single(result);

                var updatedVoucher = _dbContext.Accgl2025s.First(v => v.Id == 1m);
                Assert.Equal("ManagerA", updatedVoucher.ApprovedBy);
                Assert.NotNull(updatedVoucher.ApprovedDate);
                Assert.Equal("AuditorB", updatedVoucher.CheckedBy);
                Assert.NotNull(updatedVoucher.CheckedDate);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }

}