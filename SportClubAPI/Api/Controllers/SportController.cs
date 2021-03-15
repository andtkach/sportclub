using System;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Features.Sports.Commands.CreateSport;
using Application.Features.Sports.Commands.DeleteSport;
using Application.Features.Sports.Commands.UpdateSport;
using Application.Features.Sports.Queries.GetSportDetail;
using Application.Features.Sports.Queries.GetSportsList;
using Application.Features.Sports.Queries.GetSportsListWithItems;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SportController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllSports")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<SportListVm>>> GetAllSports()
        {
            var dtos = await _mediator.Send(new GetSportsListQuery());
            return Ok(dtos);
        }

        [HttpGet("allwithitems", Name = "GetSportsWithParticipants")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<SportParticipantListVm>>> GetSportsWithParticipants()
        {
            GetSportsListWithParticipantsQuery getSportsListWithItemsQuery = new GetSportsListWithParticipantsQuery();

            var dtos = await _mediator.Send(getSportsListWithItemsQuery);
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetSportById")]
        public async Task<ActionResult<SportDetailVm>> GetSportById(Guid id)
        {
            var getSportDetailQuery = new GetSportDetailQuery() { Id = id };
            return Ok(await _mediator.Send(getSportDetailQuery));
        }

        [Authorize]
        [HttpPost(Name = "AddSport")]
        public async Task<ActionResult<CreateSportCommandResponse>> Create([FromBody] CreateSportCommand createSportCommand)
        {
            var response = await _mediator.Send(createSportCommand);
            return Ok(response);
        }

        [Authorize]
        [HttpPut(Name = "UpdateSport")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateSportCommand updateSportCommand)
        {
            await _mediator.Send(updateSportCommand);
            return NoContent();
        }

        [Authorize]
        [HttpDelete("{id}", Name = "DeleteSport")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteSportCommand = new DeleteSportCommand() { Id = id };
            await _mediator.Send(deleteSportCommand);
            return NoContent();
        }
    }
}
