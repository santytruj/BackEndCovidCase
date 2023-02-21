﻿using Application.Features.CovidCase.Commands.CreateCovidCaseCommand;
using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CovidForState.Commands.CreateCovidForStateCommand
{
    public class CreateCovidForStateCommand : IRequest<Response<int>>
    {
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

        public class CreateCovidForStateCommandHandler : IRequestHandler<CreateCovidForStateCommand, Response<int>>
        {
            private readonly IRepositoryAsync<Domain.Entities.CovidForState> _repositoryAsync;
            private readonly IMapper _mapper;

            public CreateCovidForStateCommandHandler(IRepositoryAsync<Domain.Entities.CovidForState> repositoryAsync, IMapper mapper)
            {
                _repositoryAsync = repositoryAsync;
                _mapper = mapper;
            }

            public async Task<Response<int>> Handle(CreateCovidForStateCommand request, CancellationToken cancellationToken)
            {


                    var nuevoRegistro = _mapper.Map<Domain.Entities.CovidForState>(request);
                    var data = await _repositoryAsync.AddAsync(nuevoRegistro);

                    return new Response<int>(data.Id);


            }
        }
    }
}
