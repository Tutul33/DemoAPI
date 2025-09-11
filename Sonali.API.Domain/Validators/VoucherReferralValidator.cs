using FluentValidation;
using Sonali.API.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Domain.Validators
{
    public class VoucherReferralValidator : AbstractValidator<VoucherReferralDTO>
    {
        public VoucherReferralValidator()
        {
            RuleFor(x => x.VoucherNo)
                .NotEmpty().WithMessage("Voucher number is required")
                .MaximumLength(20).WithMessage("Voucher number cannot exceed 20 characters");

            RuleFor(x => x.RefBy)
                .NotEmpty().WithMessage("RefBy is required");

            RuleFor(x => x.RefTo)
                .NotEmpty().WithMessage("RefTo is required");

            RuleFor(x => x.RefType)
                .NotEmpty().WithMessage("RefType is required");

            RuleFor(x => x.Comments)
                .MaximumLength(1500).WithMessage("Comments cannot exceed 1500 characters");
        }
    }
}
