using System;

namespace Application.Features.Participants.Queries.GetParticipantList
{
    public class ParticipantListVm
    {
        public Guid Id { get; set; }
        
        public string ParticipantEmail { get; set; }
        
        public string Firstname { get; set; }
        
        public string Surname { get; set; }
    }
}
