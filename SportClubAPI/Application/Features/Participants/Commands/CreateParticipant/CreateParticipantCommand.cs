using System;
using MediatR;

namespace Application.Features.Participants.Commands.CreateParticipant
{
    public class CreateParticipantCommand: IRequest<Guid>
    {
        public string ParticipantEmail { get; set; }
        public Guid SportId { get; set; }
        public override string ToString()
        {
            return $"Item name: {ParticipantEmail};";
        }
    }
}
