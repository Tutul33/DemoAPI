using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Sonali.API.Middlewares
{
    public class FluentValidationActionFilter : IAsyncActionFilter
    {
        private readonly IServiceProvider _serviceProvider;

        public FluentValidationActionFilter(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            // iterate over action arguments
            foreach (var kv in context.ActionArguments)
            {
                var argName = kv.Key;
                var argValue = kv.Value;

                // get declared parameter type (use ControllerParameterDescriptor)
                var paramDescriptor = context.ActionDescriptor.Parameters
                    .OfType<ControllerParameterDescriptor>()
                    .FirstOrDefault(p => p.Name == argName);

                var modelType = paramDescriptor?.ParameterInfo.ParameterType;
                if (modelType == null) continue;

                var validatorType = typeof(IValidator<>).MakeGenericType(modelType);
                var validator = _serviceProvider.GetService(validatorType) as IValidator;
                if (validator == null) continue;

                // handle null body (if the argument value is null and there is a validator)
                if (argValue == null)
                {
                    var failure = new ValidationResult(new[]
                    {
                    new ValidationFailure(string.Empty, "Request body is required")
                });

                    context.Result = new BadRequestObjectResult(new
                    {
                        errors = failure.Errors.Select(e => new { field = e.PropertyName, error = e.ErrorMessage })
                    });

                    return;
                }

                var result = await validator.ValidateAsync(new ValidationContext<object>(argValue));
                if (!result.IsValid)
                {
                    context.Result = new BadRequestObjectResult(new
                    {
                        errors = result.Errors.Select(e => new { field = e.PropertyName, error = e.ErrorMessage })
                    });
                    return;
                }
            }

            await next();
        }
    }
}
