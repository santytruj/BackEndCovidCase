using Application.DTOs;
using Application.Interfaces;
using Application.Specifications;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CovidCases.Queries.GetAllCovidCase
{
    public class GetAllCovidCaseQuery : IRequest<PagedResponse<List<CovidCaseDto>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string? hash { get; set; }

        public class GetAllCovidCaseQueryHandler : IRequestHandler<GetAllCovidCaseQuery, PagedResponse<List<CovidCaseDto>>>
        {
            private readonly IRepositoryAsync<Domain.Entities.CovidCase> _repositoryAsync;
            private readonly IMapper _mapper;

            public GetAllCovidCaseQueryHandler(IRepositoryAsync<Domain.Entities.CovidCase> repositoryAsync, IMapper mapper)
            {
                _repositoryAsync = repositoryAsync;
                _mapper = mapper;
            }

            public async Task<PagedResponse<List<CovidCaseDto>>> Handle(GetAllCovidCaseQuery request, CancellationToken cancellationToken)
            {
                var covidcase = await _repositoryAsync.ListAsync(new PagedCovidCaseSpecification(request.PageSize, request.PageNumber, request.hash));
               
                var covidCaseDto = _mapper.Map<List<CovidCaseDto>>(covidcase);

                return new PagedResponse<List<CovidCaseDto>>(covidCaseDto, request.PageNumber, request.PageSize);
            }
        }
    }
}
