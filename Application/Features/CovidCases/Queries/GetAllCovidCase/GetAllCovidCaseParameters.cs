using Application.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CovidCases.Queries.GetAllCovidCase
{
    public class GetAllCovidCaseParameters : RequestParameters
    {
        public string? hash { get; set; }
    }
}
