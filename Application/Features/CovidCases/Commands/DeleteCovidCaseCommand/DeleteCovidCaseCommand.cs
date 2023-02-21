using Application.Interfaces;
using Application.Wrappers;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CovidCases.Commands.DeleteCovidCaseCommand
{
    public class DeleteCovidCaseCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
    }

    public class DeleteCovidCaseCommandHandler : IRequestHandler<DeleteCovidCaseCommand, Response<int>>
    {
        private readonly IRepositoryAsync<Domain.Entities.CovidCase> _repositoryAsync;

        public DeleteCovidCaseCommandHandler(IRepositoryAsync<Domain.Entities.CovidCase> repositoryAsync)
        {
            _repositoryAsync = repositoryAsync;
        }

        public async Task<Response<int>> Handle(DeleteCovidCaseCommand request, CancellationToken cancellationToken)
        {
            var covidcase = await _repositoryAsync.GetByIdAsync(request.Id);

            if (covidcase == null)
            {
                throw new KeyNotFoundException($"Registro no encontrado con el id {request.Id}");
            }
            else
            {
                await _repositoryAsync.DeleteAsync(covidcase);

                return new Response<int>(covidcase.Id);
            }
        }
    }
}
