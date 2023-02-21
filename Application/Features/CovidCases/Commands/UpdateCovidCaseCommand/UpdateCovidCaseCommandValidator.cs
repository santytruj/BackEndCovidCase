using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CovidCases.Commands.UpdateCovidCaseCommand
{
    public class UpdateCovidCaseCommandValidator : AbstractValidator<UpdateCovidCaseCommand>
    {
        public UpdateCovidCaseCommandValidator()
        {
            RuleFor(p => p.Id)
                 .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.");
        }
    }
}
