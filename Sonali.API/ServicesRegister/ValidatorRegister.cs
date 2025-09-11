using FluentValidation;
using Sonali.API.Domain.Interface;
using Sonali.API.Domain.Validators;
using Sonali.API.DomainService.Interface;
using Sonali.API.DomainService.Repository;
using Sonali.API.Infrastructure.DAL.Repository;

namespace Sonali.API.ServicesRegister
{
    public static class ValidatorRegister
    {
        public static void Register(WebApplicationBuilder builder)
        {
            builder.Services.AddValidatorsFromAssemblyContaining<VoucherReferralValidator>();

        }
    }
}
