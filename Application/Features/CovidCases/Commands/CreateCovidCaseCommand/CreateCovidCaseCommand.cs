using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Application.Features.CovidCase.Commands.CreateCovidCaseCommand
{
    public class CreateCovidCaseCommand : IRequest<Response<int>>
    {
        public int? date { get; set; }
        public int? states { get; set; }
        public int? positive { get; set; }
        public int? negative { get; set; }
        public int? pending { get; set; }
        public int? hospitalizedCurrently { get; set; }
        public int? hospitalizedCumulative { get; set; }
        public int? inIcuCurrently { get; set; }
        public int? inIcuCumulative { get; set; }
        public int? onVentilatorCurrently { get; set; }
        public int? onVentilatorCumulative { get; set; }
        public DateTime? dateChecked { get; set; }
        public int? death { get; set; }
        public int? hospitalized { get; set; }
        public int? totalTestResults { get; set; }
        public DateTime? lastModifiedTable { get; set; }
        public string recovered { get; set; }
        public int? total { get; set; }
        public int? posNeg { get; set; }
        public int? deathIncrease { get; set; }
        public int? hospitalizedIncrease { get; set; }
        public int? negativeIncrease { get; set; }
        public int? positiveIncrease { get; set; }
        public int? totalTestResultsIncrease { get; set; }
        public string hash { get; set; }
    }

    public class CreateCovidCaseCommandHandler : IRequestHandler<CreateCovidCaseCommand, Response<int>>
    {
        private readonly IRepositoryAsync<Domain.Entities.CovidCase> _repositoryAsync;
        private readonly IMapper _mapper;

        public CreateCovidCaseCommandHandler(IRepositoryAsync<Domain.Entities.CovidCase> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateCovidCaseCommand request, CancellationToken cancellationToken)
        {

                var nuevoRegistro = _mapper.Map<Domain.Entities.CovidCase>(request);
                var data = await _repositoryAsync.AddAsync(nuevoRegistro);

                return new Response<int>(data.Id);

        }
    }
}
