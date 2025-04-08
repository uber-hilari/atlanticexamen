using Atlantic.Examen.Application.Commands;
using Atlantic.Examen.Models.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantic.Examen.Application.Validators
{
    public class RegistrarAlquilerValidator : AbstractValidator<RegistrarAlquilerCommand>, IValidator<RegistrarAlquilerCommand>
    {
        public RegistrarAlquilerValidator()
        {
            RuleFor(c => c.Data)
                .NotNull()
                .ValidateData();
        }
    }

    static class RegistrarAlquilerValidatorExtensions
    {
        public static IRuleBuilderOptions<RegistrarAlquilerCommand, RegistrarAlquilerRq> ValidateData(this IRuleBuilderOptions<RegistrarAlquilerCommand, RegistrarAlquilerRq> rule)
        {
            rule.ChildRules(d =>
            {
                d.RuleFor(c => c.IdCliente)
                    .NotEqual(Guid.Empty)
                    .WithMessage("El IdCliente es obligatorio");
                d.RuleFor(c => c.QrLibro)
                    .NotEqual(Guid.Empty)
                    .WithMessage("El QrLibro es obligatorio");
                d.RuleFor(c => c.Precio)
                    .Must(v => v > 0)
                    .WithMessage("El precio debe ser positivo");
            });

            return rule;
        }
    }
}
