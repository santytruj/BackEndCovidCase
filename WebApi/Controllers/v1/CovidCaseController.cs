using Application.Features.CovidCase.Commands.CreateCovidCaseCommand;
using Application.Features.CovidCases.Commands.DeleteCovidCaseCommand;
using Application.Features.CovidCases.Commands.UpdateCovidCaseCommand;
using Application.Features.CovidCases.Queries.GetAllCovidCase;
using Application.Features.CovidCases.Queries.GetCovidCaseById;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class CovidCaseController : BaseApiController
    {
        //GET: api/<controller>
        [HttpGet()]
        [Authorize(Roles = "Buscador")]
        public async Task<IActionResult> Get([FromQuery] GetAllCovidCaseParameters filter)
        {
            return Ok(await Mediator.Send(new GetAllCovidCaseQuery {
                PageNumber = filter.PageNumber,
                PageSize = filter.PageSize,
                hash = filter.hash }));
        }


        //GET: api/<controller>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await Mediator.Send(new GetCovidCaseByIdQuery { Id = id }));
        }

        [HttpPost]
        [Authorize(Roles = "Buscador")]
        public async Task<IActionResult> Post(CreateCovidCaseCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        //PUT api/<controller>/5
        [HttpPut("{id}")]
        [Authorize(Roles = "Buscador")]
        public async Task<IActionResult> Put(int id, UpdateCovidCaseCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            return Ok(await Mediator.Send(command));
        }

        //DELETE api/<controller>/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Buscador")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteCovidCaseCommand { Id = id }));
        }

    }
}
