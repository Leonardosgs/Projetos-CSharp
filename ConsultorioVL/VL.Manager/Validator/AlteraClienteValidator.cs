using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using VL.Core.Shared.ModelViews;

namespace VL.Manager.Validator
{
    public class AlteraClienteValidator : AbstractValidator<AlteraCliente>
    {
        public AlteraClienteValidator()
        {
            RuleFor(c => c.Id).NotNull().NotEmpty().GreaterThan(0);
            Include(new NovoClienteValidator());
        }
    }
}
