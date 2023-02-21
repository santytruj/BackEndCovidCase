using Application.Features.CovidCases.Commands.DeleteCovidCaseCommand;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CovidForStates.Commands.DeleteCovidForStateCommand
{
    public class DeleteCovidForStateCommandValidator : AbstractValidator<DeleteCovidForStateCommand>
    {
        public DeleteCovidForStateCommandValidator()
        {
            RuleFor(p => p.Id)
                 .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.");
        }
    }
}
