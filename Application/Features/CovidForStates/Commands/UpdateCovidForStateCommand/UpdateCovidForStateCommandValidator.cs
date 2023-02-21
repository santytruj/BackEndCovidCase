using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CovidForStates.Commands.UpdateCovidForStateCommand
{
    public class UpdateCovidForStateCommandValidator : AbstractValidator<UpdateCovidForStateCommand>
    {
        public UpdateCovidForStateCommandValidator() 
        {
            RuleFor(p => p.Id)
                .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.");
        }
    }
}
