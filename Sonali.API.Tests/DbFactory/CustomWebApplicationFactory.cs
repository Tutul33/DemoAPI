using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Sonali.API.Domain.DTOs;
using Sonali.API.DomainService.Interface;
using Sonali.API.Infrastructure.Data.Data;
using Sonali.API.Infrastructure.Data.Models;
using System.Linq;

namespace Sonali.API.Tests.DbFactory
{
    public class CustomWebApplicationFactory<TProgram>
        : WebApplicationFactory<TProgram> where TProgram : class
    {
        protected override void ConfigureWebHost(Microsoft.AspNetCore.Hosting.IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {                
                PrepareGetVoucherListSeedData(services);
                
                // Remove real DbContext
                var descriptor = services.SingleOrDefault(
                    d => d.ServiceType == typeof(DbContextOptions<AppDbContext>));
                if (descriptor != null)
                    services.Remove(descriptor);
                // Add in-memory DbContext
                services.AddDbContext<AppDbContext>(options =>
                    options.UseInMemoryDatabase("IntegrationTestDb"));

                services.AddAuthentication("Test")
               .AddScheme<AuthenticationSchemeOptions, TestAuthHandler>("Test", options => { });

            }).ConfigureTestContainer<IServiceProvider>(sp =>
            {
                // Seed data using the built container
                using var scope = sp.CreateScope();
                var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                db.Database.EnsureCreated();

                if (!db.Accgl2025s.Any())
                {
                    db.Accgl2025s.AddRange(
                        new Accgl2025 { Id = 1m, VoucherNo = "V001", Damount = 100, Camount = 50 },
                        new Accgl2025 { Id = 2m, VoucherNo = "V002", Damount = 200, Camount = 150 }
                    );
                    db.SaveChanges();
                }
            });

        }

        private static void PrepareGetVoucherListSeedData(IServiceCollection services)
        {
            try
            {
                // 1. Remove the real data service if registered
                var descriptorSvc = services.SingleOrDefault(
                    d => d.ServiceType == typeof(IAccountingDomainService));
                if (descriptorSvc != null)
                    services.Remove(descriptorSvc);

                // 2. Add a mock data service
                var mockService = new Mock<IAccountingDomainService>();
                mockService.Setup(s => s.GetVoucherList(It.IsAny<VoucherSearchDTO>()))
                           .ReturnsAsync(new
                           {
                               list = new[]
                               {
                               new { VoucherNo = "V001", Damount = 100, Camount = 50 },
                               new { VoucherNo = "V002", Damount = 200, Camount = 150 }
                               }
                           });


                services.AddSingleton(mockService.Object);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
