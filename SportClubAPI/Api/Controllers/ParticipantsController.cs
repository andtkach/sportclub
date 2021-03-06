using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Features.Participants.Commands.CreateParticipant;
using Application.Features.Participants.Commands.DeleteParticipant;
using Application.Features.Participants.Commands.UpdateParticipant;
using Application.Features.Participants.Queries.GetParticipantDetail;
using Application.Features.Participants.Queries.GetParticipantList;
using Application.Features.Participants.Queries.GetParticipantSportsList;
using Microsoft.AspNetCore.Authorization;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParticipantsController : Controller
    {
        private readonly IMediator _mediator;

        public ParticipantsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetAllParticipants")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<ParticipantListVm>>> GetAllParticipants()
        {
            var dtos = await _mediator.Send(new GetParticipantsListQuery());
            return Ok(dtos);
        }

        [HttpGet("{email}/sports", Name = "GetParticipantSports")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<ParticipantSportsListVm>>> GetParticipantSports(string email)
        {
            var dtos = await _mediator.Send(new GetParticipantSportsListQuery() { Email = email });
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetParticipantById")]
        public async Task<ActionResult<ParticipantDetailVm>> GetParticipantById(Guid id)
        {
            var getParticipantDetailQuery = new GetParticipantDetailQuery() { Id = id };
            return Ok(await _mediator.Send(getParticipantDetailQuery));
        }

        [Authorize]
        [HttpPost(Name = "AddParticipant")]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateParticipantCommand createParticipantCommand)
        {
            var id = await _mediator.Send(createParticipantCommand);
            return Ok(id);
        }

        [Authorize]
        [HttpPut(Name = "UpdateParticipant")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateParticipantCommand updateParticipantCommand)
        {
            await _mediator.Send(updateParticipantCommand);
            return NoContent();
        }

        [Authorize]
        [HttpDelete("{id}", Name = "DeleteParticipant")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteParticipantCommand = new DeleteParticipantCommand() { Id = id };
            await _mediator.Send(deleteParticipantCommand);
            return NoContent();
        }
    }
}
