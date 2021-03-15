using System;
using MediatR;

namespace Application.Features.Participants.Commands.DeleteParticipant
{
    public class DeleteParticipantCommand: IRequest
    {
        public Guid Id { get; set; }
    }
}
