using System;
using MediatR;

namespace Application.Features.Participants.Commands.CreateParticipant
{
    public class CreateParticipantCommand: IRequest<Guid>
    {
        public string ParticipantEmail { get; set; }
        
        public string Firstname { get; set; }
        
        public string Surname { get; set; }
        
        public Guid SportId { get; set; }
        
        public override string ToString()
        {
            return $"Item name: {ParticipantEmail};";
        }
    }
}
