using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CovidForStates.Commands.UpdateCovidForStateCommand
{
    public class UpdateCovidForStateCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
        public int? date { get; set; }
        public string state { get; set; }
        public int? positive { get; set; }
        public int? probableCases { get; set; }
        public int? negative { get; set; }
        public string pending { get; set; }
        public string totalTestResultsSource { get; set; }
        public int? totalTestResults { get; set; }
        public int? hospitalizedCurrently { get; set; }
        public int? hospitalizedCumulative { get; set; }
        public int? inIcuCurrently { get; set; }
        public int? inIcuCumulative { get; set; }
        public int? onVentilatorCurrently { get; set; }
        public int? onVentilatorCumulative { get; set; }
        public int? recovered { get; set; }
        public string lastUpdateEt { get; set; }
        public DateTime? dateModified { get; set; }
        public string checkTimeEt { get; set; }
        public int? death { get; set; }
        public int? hospitalized { get; set; }
        public int? hospitalizedDischarged { get; set; }
        public DateTime? dateChecked { get; set; }
        public int? totalTestsViral { get; set; }
        public int? positiveTestsViral { get; set; }
        public int? negativeTestsViral { get; set; }
        public int? positiveCasesViral { get; set; }
        public int? deathConfirmed { get; set; }
        public int? deathProbable { get; set; }
        public int? totalTestEncountersViral { get; set; }
        public int? totalTestsPeopleViral { get; set; }
        public int? totalTestsAntibody { get; set; }
        public int? positiveTestsAntibody { get; set; }
        public int? negativeTestsAntibody { get; set; }
        public int? totalTestsPeopleAntibody { get; set; }
        public string positiveTestsPeopleAntibody { get; set; }
        public string negativeTestsPeopleAntibody { get; set; }
        public int? totalTestsPeopleAntigen { get; set; }
        public int? positiveTestsPeopleAntigen { get; set; }
        public string totalTestsAntigen { get; set; }
        public string positiveTestsAntigen { get; set; }
        public string fips { get; set; }
        public int? positiveIncrease { get; set; }
        public int? negativeIncrease { get; set; }
        public int? total { get; set; }
        public int? totalTestResultsIncrease { get; set; }
        public int? posNeg { get; set; }
        public string dataQualityGrade { get; set; }
        public int? deathIncrease { get; set; }
        public int? hospitalizedIncrease { get; set; }
        public string hash { get; set; }
        public int commercialScore { get; set; }
        public int? negativeRegularScore { get; set; }
        public int? negativeScore { get; set; }
        public int? positiveScore { get; set; }
        public int? score { get; set; }
        public string grade { get; set; }
    }

    public class UpdateCovidForStateCommandHandler : IRequestHandler<UpdateCovidForStateCommand, Response<int>>
    {
        private readonly IRepositoryAsync<Domain.Entities.CovidForState> _repositoryAsync;
        private readonly IMapper _mapper;

        public UpdateCovidForStateCommandHandler(IRepositoryAsync<Domain.Entities.CovidForState> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(UpdateCovidForStateCommand request, CancellationToken cancellationToken)
        {
            var covidforstate = await _repositoryAsync.GetByIdAsync(request.Id);

            if (covidforstate == null)
            {
                throw new KeyNotFoundException($"Registro no encontrado con el id {request.Id}");
            }
            else
            {
                covidforstate.date = request.date;
                covidforstate.state = request.state;
                covidforstate.positive = request.positive;
                covidforstate.negative = request.negative;
                covidforstate.pending = request.pending;
                covidforstate.totalTestResults = request.totalTestResults;
                covidforstate.hospitalizedCurrently = request.hospitalizedCurrently;
                covidforstate.hospitalizedCumulative = request.hospitalizedCumulative;
                covidforstate.inIcuCurrently = request.inIcuCurrently;
                covidforstate.inIcuCumulative = request.inIcuCumulative;
                covidforstate.onVentilatorCurrently = request.onVentilatorCurrently;
                covidforstate.onVentilatorCumulative = request.onVentilatorCumulative;
                covidforstate.recovered = request.recovered;
                covidforstate.death = request.death;
                covidforstate.hospitalized = request.hospitalized;
                covidforstate.hospitalizedDischarged = request.hospitalizedDischarged;
                covidforstate.totalTestsViral = request.totalTestsViral;
                covidforstate.positiveTestsViral = request.positiveTestsViral;
                covidforstate.negativeTestsViral = request.negativeTestsViral;
                covidforstate.positiveCasesViral = request.positiveCasesViral;
                covidforstate.deathConfirmed = request.deathConfirmed;
                covidforstate.deathProbable = request.deathProbable;
                covidforstate.totalTestEncountersViral = request.totalTestEncountersViral;
                covidforstate.totalTestsPeopleViral = request.totalTestsPeopleViral;
                covidforstate.totalTestsAntibody = request.totalTestsAntibody;
                covidforstate.positiveTestsAntibody = request.positiveTestsAntibody;
                covidforstate.negativeTestsAntibody = request.negativeTestsAntibody;
                covidforstate.totalTestsPeopleAntibody = request.totalTestsPeopleAntibody;
                covidforstate.positiveTestsPeopleAntibody = request.positiveTestsPeopleAntibody;
                covidforstate.negativeTestsPeopleAntibody = request.negativeTestsPeopleAntibody;
                covidforstate.totalTestsPeopleAntigen = request.totalTestsPeopleAntigen;
                covidforstate.positiveTestsPeopleAntigen = request.positiveTestsPeopleAntigen;
                covidforstate.totalTestsAntigen = request.totalTestsAntigen;
                covidforstate.positiveTestsAntigen = request.positiveTestsAntigen;
                covidforstate.fips = request.fips;
                covidforstate.positiveIncrease = request.positiveIncrease;
                covidforstate.negativeIncrease = request.negativeIncrease;
                covidforstate.total = request.total;
                covidforstate.totalTestResultsIncrease = request.totalTestResultsIncrease;
                covidforstate.posNeg = request.posNeg;
                covidforstate.dataQualityGrade = request.dataQualityGrade;
                covidforstate.deathIncrease = request.deathIncrease;
                covidforstate.hospitalizedIncrease = request.hospitalizedIncrease;
                covidforstate.hash = request.hash;
                covidforstate.commercialScore = request.commercialScore;
                covidforstate.negativeRegularScore = request.negativeRegularScore;
                covidforstate.negativeScore = request.negativeScore;
                covidforstate.positiveScore = request.positiveScore;
                covidforstate.score = request.score;
                covidforstate.grade = request.grade;

                await _repositoryAsync.UpdateAsync(covidforstate);

                return new Response<int>(covidforstate.Id);
            }
        }
    }
}
