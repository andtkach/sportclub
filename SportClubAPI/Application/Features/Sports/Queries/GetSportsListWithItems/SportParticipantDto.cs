using System;

namespace Application.Features.Sports.Queries.GetSportsListWithItems
{
    public class SportParticipantDto
    {
        public Guid Id { get; set; }
        public string ParticipantEmail { get; set; }
        public Guid SportId { get; set; }
    }
}
