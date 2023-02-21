using Application.DTOs;
using Application.Features.CovidCases.Queries.GetAllCovidCase;
using Application.Interfaces;
using Application.Specifications;
using Application.Wrappers;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CovidForStates.Queries.GetAllCovidForState
{
    public class GetAllCovidForStateQuery : IRequest<PagedResponse<List<CovidForStateDto>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string? hash { get; set; }

        public class GetAllCovidForStateQueryHandler : IRequestHandler<GetAllCovidForStateQuery, PagedResponse<List<CovidForStateDto>>>
        {
            private readonly IRepositoryAsync<Domain.Entities.CovidForState> _repositoryAsync;
            private readonly IMapper _mapper;

            public GetAllCovidForStateQueryHandler(IRepositoryAsync<Domain.Entities.CovidForState> repositoryAsync, IMapper mapper)
            {
                _repositoryAsync = repositoryAsync;
                _mapper = mapper;
            }

            public async Task<PagedResponse<List<CovidForStateDto>>> Handle(GetAllCovidForStateQuery request, CancellationToken cancellationToken)
            {
                var covidforstate = await _repositoryAsync.ListAsync(new PagedCovidForStateSpecification(request.PageSize, request.PageNumber, request.hash));
                var covidForStateDto = _mapper.Map<List<CovidForStateDto>>(covidforstate);

                return new PagedResponse<List<CovidForStateDto>>(covidForStateDto, request.PageNumber, request.PageSize);
            }
        }
    }
}
