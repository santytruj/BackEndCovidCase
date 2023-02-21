using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CovidCases.Commands.DeleteCovidCaseCommand
{
 
        public class DeleteCovidCaseCommandValidator : AbstractValidator<DeleteCovidCaseCommand>
        {
            public DeleteCovidCaseCommandValidator()
            {
                RuleFor(p => p.Id)
                     .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.");
            }
        }
    
}
