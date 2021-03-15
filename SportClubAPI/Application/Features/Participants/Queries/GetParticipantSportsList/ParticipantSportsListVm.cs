using System;

namespace Application.Features.Participants.Queries.GetParticipantSportsList
{
    public class ParticipantSportsListVm
    {
        public Guid Id { get; set; }
        
        public string ParticipantEmail { get; set; }
        
        public string Firstname { get; set; }
        
        public string Surname { get; set; }
        
        public Guid SportId { get; set; }
        
        public string SportName { get; set; }
    }
}
