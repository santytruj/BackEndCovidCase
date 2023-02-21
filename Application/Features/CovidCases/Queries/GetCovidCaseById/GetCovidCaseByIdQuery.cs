using Application.DTOs;
using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CovidCases.Queries.GetCovidCaseById
{
    public class GetCovidCaseByIdQuery : IRequest<Response<CovidCaseDto>>
    {
        public int Id { get; set; } 

        public class GetCovidCaseByIdQueryHandler : IRequestHandler<GetCovidCaseByIdQuery, Response<CovidCaseDto>>
        {
            private readonly IRepositoryAsync<Domain.Entities.CovidCase> _repositoryAsync;
            private readonly IMapper _mapper;

            public GetCovidCaseByIdQueryHandler(IRepositoryAsync<Domain.Entities.CovidCase> repositoryAsync, IMapper mapper)
            {
                _repositoryAsync = repositoryAsync;
                _mapper = mapper;
            }

            public async Task<Response<CovidCaseDto>> Handle(GetCovidCaseByIdQuery request, CancellationToken cancellationToken)
            {
                var covidcase = await _repositoryAsync.GetByIdAsync(request.Id);

                if (covidcase == null)
                {
                    throw new KeyNotFoundException($"Registro no encontrado con el id {request.Id}");
                }
                else
                {
                    var dto = _mapper.Map<CovidCaseDto>(covidcase);

                    return new Response<CovidCaseDto>(dto);
                }
          
            }
        }
    }
}
