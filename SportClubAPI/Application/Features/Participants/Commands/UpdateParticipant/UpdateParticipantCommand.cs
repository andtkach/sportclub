using System;
using MediatR;

namespace Application.Features.Participants.Commands.UpdateParticipant
{
    public class UpdateParticipantCommand: IRequest
    {
        public Guid Id { get; set; }
        
        public string ParticipantEmail { get; set; }
        
        public string Firstname { get; set; }
        
        public string Surname { get; set; }
        
        public Guid SportId { get; set; }
    }
}
