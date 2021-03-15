using System;

namespace Application.Features.Sports.Queries.GetSportsListWithItems
{
    public class SportParticipantDto
    {
        public Guid Id { get; set; }
     
        public string ParticipantEmail { get; set; }
      
        public string Firstname { get; set; }
      
        public string Surname { get; set; }
       
        public Guid SportId { get; set; }
    }
}
