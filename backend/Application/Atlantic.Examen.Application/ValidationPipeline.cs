using Atlantic.Examen.Domain.Exceptions;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantic.Examen.Application
{
    public class ValidationPipeline<TRequest, TResponse>(IEnumerable<IValidator<TRequest>> validators)
        : IPipelineBehavior<TRequest, TResponse>
        where TRequest : notnull
    {
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var context = new ValidationContext<TRequest>(request);

            var validations = await Task.WhenAll(validators.Select(v => v.ValidateAsync(context, cancellationToken)));

            var errors = validations.Where(vr => vr.IsValid == false)
                .SelectMany(vr => vr.Errors)
                .Select(vf => new Error(40010, $"{vf.PropertyName}: {vf.ErrorMessage}"))
                .ToList();

            if (errors.Any())
            {
                throw new InvalidCommandException(errors);
            }

            var result = await next(cancellationToken);

            return result;
        }
    }
}
