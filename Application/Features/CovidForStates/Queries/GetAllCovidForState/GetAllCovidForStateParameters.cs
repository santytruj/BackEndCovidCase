using Application.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CovidForStates.Queries.GetAllCovidForState
{
    public class GetAllCovidForStateParameters : RequestParameters
    {
        public string? hash { get; set; }
    }
}
