using Application.DTOs;
using Application.Features.CovidCase.Commands.CreateCovidCaseCommand;
using Application.Features.CovidForState.Commands.CreateCovidForStateCommand;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile() 
        {
            #region Dtos
            CreateMap<CovidCase, CovidCaseDto>();
            CreateMap<CovidForState, CovidForStateDto>();
            #endregion
            #region Commands
            CreateMap<CreateCovidCaseCommand, CovidCase>();
            CreateMap<CreateCovidForStateCommand, CovidForState>();
            #endregion

        }
    }
}
