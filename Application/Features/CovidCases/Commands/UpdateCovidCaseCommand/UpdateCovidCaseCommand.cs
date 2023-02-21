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

namespace Application.Features.CovidCases.Commands.UpdateCovidCaseCommand
{
    public class UpdateCovidCaseCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
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

    public class UpdateCovidCaseCommandHandler : IRequestHandler<UpdateCovidCaseCommand, Response<int>>
    {
        private readonly IRepositoryAsync<Domain.Entities.CovidCase> _repositoryAsync;
        private readonly IMapper _mapper;

        public UpdateCovidCaseCommandHandler(IRepositoryAsync<Domain.Entities.CovidCase> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(UpdateCovidCaseCommand request, CancellationToken cancellationToken)
        {
            var covidcase = await _repositoryAsync.GetByIdAsync(request.Id);

            if (covidcase == null)
            {
                throw new KeyNotFoundException($"Registro no encontrado con el id {request.Id}");
            }
            else
            {
                covidcase.date = request.date;
                covidcase.states = request.states;
                covidcase.positive = request.positive;
                covidcase.negative = request.negative;
                covidcase.pending = request.pending;
                covidcase.hospitalizedCurrently = request.hospitalizedCurrently;
                covidcase.hospitalizedCumulative = request.hospitalizedCumulative;
                covidcase.inIcuCurrently = request.inIcuCurrently;
                covidcase.inIcuCumulative = request.inIcuCumulative;
                covidcase.onVentilatorCurrently = request.onVentilatorCurrently;
                covidcase.onVentilatorCumulative = request.onVentilatorCumulative;
                covidcase.dateChecked = request.dateChecked;
                covidcase.death = request.death;
                covidcase.hospitalized = request.hospitalized;
                covidcase.totalTestResults = request.totalTestResults;
                covidcase.lastModifiedTable = request.lastModifiedTable;
                covidcase.recovered = request.recovered;
                covidcase.total = request.total;
                covidcase.posNeg = request.posNeg;
                covidcase.deathIncrease = request.deathIncrease;
                covidcase.hospitalizedIncrease = request.hospitalizedIncrease;
                covidcase.negativeIncrease = request.negativeIncrease;
                covidcase.positiveIncrease = request.positiveIncrease;
                covidcase.totalTestResultsIncrease = request.totalTestResultsIncrease;
                covidcase.hash = request.hash;

                await _repositoryAsync.UpdateAsync(covidcase);

                return new Response<int>(covidcase.Id);
            }
        }
    }
}
