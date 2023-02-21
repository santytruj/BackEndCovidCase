using Application.DTOs;
using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CovidForStates.Queries.GetCovidForStateById
{
    public class GetCovidForStateByIdQuery : IRequest<Response<CovidForStateDto>>
    {
        public int Id { get; set; }

        public class GetCovidForStateByIdQueryHablder : IRequestHandler<GetCovidForStateByIdQuery, Response<CovidForStateDto>>
        {
            private readonly IRepositoryAsync<Domain.Entities.CovidForState> _repositoryAsync;
            private readonly IMapper _mapper;

            public GetCovidForStateByIdQueryHablder(IRepositoryAsync<Domain.Entities.CovidForState> repositoryAsync, IMapper mapper)
            {
                _repositoryAsync = repositoryAsync;
                _mapper = mapper;
            }

            public async Task<Response<CovidForStateDto>> Handle(GetCovidForStateByIdQuery request, CancellationToken cancellationToken)
            {
                var covidforstate = await _repositoryAsync.GetByIdAsync(request.Id);

                if (covidforstate == null)
                {
                    throw new KeyNotFoundException($"Registro no encontrado con el id {request.Id}");
                }
                else
                {
                    var dto = _mapper.Map<CovidForStateDto>(covidforstate);

                    return new Response<CovidForStateDto>(dto);
                }
            }
        }
    }
}
