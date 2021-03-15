using System;
using MediatR;

namespace Application.Features.Participants.Commands.UpdateParticipant
{
    public class UpdateParticipantCommand: IRequest
    {
        public Guid Id { get; set; }
        public string ParticipantEmail { get; set; }
        public Guid SportId { get; set; }
    }
}
