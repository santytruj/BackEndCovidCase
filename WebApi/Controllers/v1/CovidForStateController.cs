using Application.Enums;
using Application.Features.CovidCase.Commands.CreateCovidCaseCommand;
using Application.Features.CovidCases.Commands.DeleteCovidCaseCommand;
using Application.Features.CovidCases.Commands.UpdateCovidCaseCommand;
using Application.Features.CovidCases.Queries.GetAllCovidCase;
using Application.Features.CovidCases.Queries.GetCovidCaseById;
using Application.Features.CovidForState.Commands.CreateCovidForStateCommand;
using Application.Features.CovidForStates.Commands.DeleteCovidForStateCommand;
using Application.Features.CovidForStates.Commands.UpdateCovidForStateCommand;
using Application.Features.CovidForStates.Queries.GetAllCovidForState;
using Application.Features.CovidForStates.Queries.GetCovidForStateById;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class CovidForStateController : BaseApiController
    {

        //GET: api/<controller>
        [HttpGet()]
        [Authorize(Roles = "Ciudadado")]
        public async Task<IActionResult> Get([FromQuery] GetAllCovidForStateParameters filter)
        {
            return Ok(await Mediator.Send(new GetAllCovidForStateQuery
            {
                PageNumber = filter.PageNumber,
                PageSize = filter.PageSize,
                hash = filter.hash
            }));
        }


        //GET: api/<controller>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await Mediator.Send(new GetCovidForStateByIdQuery { Id = id }));
        }

        [HttpPost]
        [Authorize(Roles = "Ciudadado")]
        public async Task<IActionResult> Post(CreateCovidForStateCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        //PUT api/<controller>/5
        [HttpPut("{id}")]
        [Authorize(Roles = "Ciudadado")]
        public async Task<IActionResult> Put(int id, UpdateCovidForStateCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            return Ok(await Mediator.Send(command));
        }

        //DELETE api/<controller>/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Ciudadado")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteCovidForStateCommand { Id = id }));
        }
    }
}
