using Application.Features.CovidCases.Commands.DeleteCovidCaseCommand;
using Application.Interfaces;
using Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CovidForStates.Commands.DeleteCovidForStateCommand
{
    public class DeleteCovidForStateCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
    }

    public class DeleteCovidForStateCommandHandler : IRequestHandler<DeleteCovidForStateCommand, Response<int>>
    {
        private readonly IRepositoryAsync<Domain.Entities.CovidForState> _repositoryAsync;

        public DeleteCovidForStateCommandHandler(IRepositoryAsync<Domain.Entities.CovidForState> repositoryAsync)
        {
            _repositoryAsync = repositoryAsync;
        }

        public async Task<Response<int>> Handle(DeleteCovidForStateCommand request, CancellationToken cancellationToken)
        {
            var covidforstate = await _repositoryAsync.GetByIdAsync(request.Id);

            if (covidforstate == null)
            {
                throw new KeyNotFoundException($"Registro no encontrado con el id {request.Id}");
            }
            else
            {
                await _repositoryAsync.DeleteAsync(covidforstate);

                return new Response<int>(covidforstate.Id);
            }
        }
    }
}
